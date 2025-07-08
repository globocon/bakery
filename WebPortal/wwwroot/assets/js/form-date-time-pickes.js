$(function() {
	"use strict";
	
	
	    $('.datepicker').pickadate({
			selectMonths: true,
			selectYears: true,
			format: 'yyyy-mm-dd',        // display format in input
			formatSubmit: 'yyyy-mm-dd',  // optional if submitting via form
			hiddenName: true             // use this if you're submitting via form
		}),
		$('.timepicker').pickatime();
		
		
		$(function () {
			$('#date-time').bootstrapMaterialDatePicker({
				format: 'YYYY-MM-DD HH:mm'
			});
			$('#date').bootstrapMaterialDatePicker({
				time: false
			});
			$('#time').bootstrapMaterialDatePicker({
				date: false,
				format: 'HH:mm'
			});
		});
	
	
	});