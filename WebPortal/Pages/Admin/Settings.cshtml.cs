
using BMS.Data.Helpers;
using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using System;
using System.Linq;
using System.Security.Claims;
using BMS.Data.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace Unece.MSTCTS.Pages.Admin
{
    [Authorize]
    public class SettingsModel : PageModel
    {


        private readonly IUserDataProvider _userDataProvider;
        private readonly IFieldDataProvider _fieldDataProvider;
        private readonly IFeatureDataProvider _featureDataProvider;
        private readonly IAspNetUserDataprovider _aspnetuserDataProvider;
        private readonly IAspNetRoleDataprovider _aspnetroleDataProvider;
        private readonly IUserAccessDataProvider _useraccessDataProvider;

        public SettingsModel(IWebHostEnvironment webHostEnvironment,
            IUserDataProvider userDataProvider,
            IFieldDataProvider fieldDataProvider,
            IFeatureDataProvider featureDataProvider,
            IAspNetUserDataprovider aspnetuserDataProvider,
            IAspNetRoleDataprovider aspnetroleDataProvider,
            IUserAccessDataProvider useraccessDataProvider
            )
        {

            _userDataProvider = userDataProvider;
            _fieldDataProvider = fieldDataProvider;
            _featureDataProvider = featureDataProvider;
            _aspnetuserDataProvider = aspnetuserDataProvider;
            _aspnetroleDataProvider = aspnetroleDataProvider;
            _useraccessDataProvider = useraccessDataProvider;

        }
        public ActionResult OnGet()
        {            
            if (!AuthUserHelper.IsAdminUserLoggedIn)
                return Redirect(Url.Page("/Account/Unauthorized"));

            return Page();			
		}

        #region FieldDataProvider
        public IFieldDataProvider FieldDataProvider { get { return _fieldDataProvider; } }
        public IFeatureDataProvider FeatureDataProvider { get { return _featureDataProvider; } }

        public IAspNetUserDataprovider AspNetUserDataprovider { get { return _aspnetuserDataProvider; } }
        public IAspNetRoleDataprovider AspNetRoleDataprovider { get { return _aspnetroleDataProvider; } }
        #endregion


        #region User
        public JsonResult OnGetUsers()
        {
            var users = _userDataProvider.GetUsers().Result.Select(x => new { x.id, x.firstName_lastName, x.email, x.indexnumber, x.active });
            return new JsonResult(users);
        }
               
        public JsonResult OnPostUser(USR_Users record)
        {
            var status = true;
            var message = "Success";
            try
            {
                if (record != null)
                {
                    record.Password = PasswordHelper.EncryptPassword(record.Password);
                    _userDataProvider.SaveUser(record);
                }
            }
            catch (Exception ex)
            {
                status = false;
                message = "Error " + ex.Message;

                if (ex.InnerException != null &&
                    ex.InnerException is SqlException &&
                    ex.InnerException.Message.StartsWith("Violation of UNIQUE KEY constraint"))
                {
                    message = "A user with this username already exists";
                }
            }

            return new JsonResult(new { status = status, message = message });
        }

        #endregion User
                
        #region field 
        public IActionResult OnGetFieldTypeList()
        {
            return new JsonResult(_fieldDataProvider.GetFieldTypes());
        }
        public JsonResult OnGetFieldDetails(int typeId)
        {
            var fields = _fieldDataProvider.GetFieldDetails(typeId);
            return new JsonResult(fields);
        }

        public JsonResult OnPostFieldDetails(FieldDetails reportfield)
        {
            var status = true;
            var message = "Success";
            var success = 1;
            try
            {
                success = _fieldDataProvider.AddorUpdateFieldDetails(reportfield);
                if (success != 1)
                {
                    if (success == 2)
                        message = "The detail you have entered already exists for this title. Please enter different detail.";
                    else if (success == 3)
                        message = "The detail you have entered already exists for this title. Please enter different detail.";
                    status = false;
                }


            }
            catch (Exception ex)
            {
                status = false;
                message = "Error " + ex.Message;
            }

            return new JsonResult(new { status = status, message = message });
        }


        public JsonResult OnPostDeleteFieldDetails(int id)
        {
            var status = true;
            var message = "Success";
            try
            {
                _fieldDataProvider.DeleteFieldDetails(id);
            }
            catch (Exception ex)
            {
                status = false;
                message = "Error " + ex.Message;
            }

            return new JsonResult(new { status = status, message = message });
        }

        public JsonResult OnPostFieldType(FieldTypeMaster ClientSiteLinksPageTyperecord)
        {
            var status = 0;
            var message = "Success";
            try
            {
                if (ClientSiteLinksPageTyperecord != null)
                {

                    status = _fieldDataProvider.SaveFieldType(ClientSiteLinksPageTyperecord);
                    if (status == -1)
                    {

                        message = "Same button name already exist";


                    }
                }
            }
            catch (Exception ex)
            {
                status = 0;
                message = "Error " + ex.Message;


            }

            return new JsonResult(new { status = status, message = message });
        }

        public JsonResult OnPostDeleteFieldType(int TypeId)
        {
            var status = 0;
            var message = "Success";
            try
            {
                if (TypeId != 0)
                {

                    status = _fieldDataProvider.DeleteFieldType(TypeId);

                }
            }
            catch (Exception ex)
            {
                status = 0;
                message = "Error " + ex.Message;


            }

            return new JsonResult(new { status = status, message = message });
        }
        #endregion

        #region Feature
        public JsonResult OnGetUserAccess()
        {
            //var users = _useraccessDataProvider.GetUserAccess().Select(x => new {x.FeatureMaster.FeatureName,x.AspNetRoles.Name, x.AspNetUsers.UserName, x.Id,x.FeatureId, x.RoleId, x.UserId, x.IsEnabled });
            var users = _useraccessDataProvider.GetUserAccess().Select(x => new { x.FeatureName, x.Name, x.UserName, x.Id, x.FeatureId, x.RoleId, x.UserId, x.IsEnabled,x.FirstName });
            return new JsonResult(users);
        }
        public JsonResult OnPostUserAccess(USR_UserAccess record)
        {
            var status = true;
            var message = "Success";
            var success = 1;
            try
            {
                if (record != null)
                {
                    success = _useraccessDataProvider.SaveUserAccess(record);
                    if (success != 1)
                    {
                        if (success == 2)
                            message = "Feature Already Assigned For This Role.";
                        else if (success == 3)
                            message = "Feature Already Assigned For This User.";
                        status = false;
                    }
                }
            }
            catch (Exception ex)
            {
                status = false;
                message = "Error " + ex.Message;
            }

            return new JsonResult(new { status = status, message = message });
        }
        public JsonResult OnPostDeleteUserAccess(int id)
        {
            var status = true;
            var message = "Success";
            try
            {
                _useraccessDataProvider.DeleteUserAccess(id);
            }
            catch (Exception ex)
            {
                status = false;
                message = "Error " + ex.Message;
            }

            return new JsonResult(new { status = status, message = message });
        }
        public IActionResult OnGetFeatures()
        {
            return new JsonResult(_featureDataProvider.GetFeatures());
        }

        #endregion

        #region Roles

        public JsonResult OnGetRoleList()
        {            
            var roles = _aspnetroleDataProvider.GetAspNetRole().ToList();
            return new JsonResult(roles);
        }

        public JsonResult OnGetrole(string id)
        {
            var role = _aspnetroleDataProvider.GetAspNetSingleRole(id);
            return new JsonResult(role);
        }

        public JsonResult OnPostAddRole(string id,string rolename)
        {
            bool status = true;
            string message = "Success";
            if (string.IsNullOrEmpty(id))
            {
                status = false;
                message = "Invalid role id or name.";
            }
            else
            {
                try
                {
                    status = _aspnetroleDataProvider.AddRole(id, rolename, out message);
                }
                catch (Exception ex)
                {
                    status = false;
                    message = "Error " + ex.Message;
                }
            }
            return new JsonResult(new { status = status, message = message });
        }

        public JsonResult OnPostUpdateRole(string id, string rolename)
        {
            bool status = true;
            string message = "Success";
            if(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(rolename))
            {
                status = false;
                message = "Invalid role id or name.";
            }
            else
            {
                try
                {
                    status = _aspnetroleDataProvider.UpdateRole(id, rolename, out message);
                }
                catch (Exception ex)
                {
                    status = false;
                    message = "Error " + ex.Message;
                }
            }
           

            return new JsonResult(new { status = status, message = message });
        }

        public JsonResult OnPostDeleteRole(string id)
        {
            bool status = true;
            string message = "Success";
            if (string.IsNullOrEmpty(id))
            {
                status = false;
                message = "Invalid role id.";
            }
            else
            {
                try
                {
                    status = _aspnetroleDataProvider.DeleteRole(id, out message);
                }
                catch (Exception ex)
                {
                    status = false;
                    message = "Error " + ex.Message;
                }
            }
            return new JsonResult(new { status = status, message = message });
        }

        #endregion

    }
}
