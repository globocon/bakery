//$(function() {
//	"use strict";


//	    // Example starter JavaScript for disabling form submissions if there are invalid fields
//			(function () {
//			  'use strict'

//			  // Fetch all the forms we want to apply custom Bootstrap validation styles to
//			  var forms = document.querySelectorAll('.needs-validation')

//			  // Loop over them and prevent submission
//			  Array.prototype.slice.call(forms)
//				.forEach(function (form) {
//				  form.addEventListener('submit', function (event) {
//					if (!form.checkValidity()) {
//					  event.preventDefault()
//					  event.stopPropagation()
//					}

//					form.classList.add('was-validated')
//				  }, false)
//				})
//			})()


//	});


//$(function () {
//    "use strict";

//    // Bootstrap validation on button click instead of form submit
//    (function () {
//        'use strict';

//        // Get all forms with the class 'needs-validation'
//        var forms = document.querySelectorAll('.needs-validation');

//        // Loop over each form
//        Array.prototype.slice.call(forms)
//            .forEach(function (form) {

//                // Find the button with a custom class or ID (e.g., .btn-validate)
//                var validateBtn = form.querySelector('.btn-validate');
//                if (validateBtn) {
//                    validateBtn.addEventListener('click', function (event) {

//                        // Check if the form is valid
//                        if (!form.checkValidity()) {
//                            event.preventDefault();
//                            event.stopPropagation();
//                        } else {
//                            // Form is valid — you can manually submit or do something else
//                            console.log("Form is valid");
//                            // Example: form.submit(); (optional)
//                        }

//                        // Add Bootstrap validation styles
//                        form.classList.add('was-validated');
//                    }, false);
//                }
//            });
//    })();
//});


function validateBootstrapForm(formId) {
    'use strict';

    var form = document.getElementById(formId);

    if (!form) {
        console.warn('Form with ID "' + formId + '" not found.');
        return false;
    }

    if (!form.checkValidity()) {
        form.classList.add('was-validated');
        return false;
    }

    form.classList.add('was-validated');
    return true;
}

function resetBootstrapValidation(formId) {
    const form = document.getElementById(formId);

    if (!form) {
        console.warn(`Form with ID "${formId}" not found.`);
        return;
    }

    // Reset form values (optional)
    form.reset();

    // Remove validation classes
    form.classList.remove('was-validated');

    // Remove Bootstrap's validation styles from each field
    const elements = form.querySelectorAll('.is-valid, .is-invalid');
    elements.forEach(el => {
        el.classList.remove('is-valid');
        el.classList.remove('is-invalid');
    });
}
