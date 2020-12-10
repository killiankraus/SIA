$(document).ready(function () {

    $("#registrationForm").validate({
        rules: {
            Firstname: {
                required: true
            },
            Lastname: {
                required: true
            },
            Birthdate: {
                required: true,
                date: true
            },
            Username: {
                required: true,
                remote: "../Home/checkUserName"
            },
            Password: {
                required: true,
                minlength: 8,
                passwordRegex: true
            },
            Confirmpassword: {
                required: true,
                minlength: 8,
                equalTo: "#Password"
            }
        },
        messages: {
            Firstname: "Please provide your First Name",
            Lastname: "Please provide your Last Name",
            Birthdate: {
                required: "Please provide your Birthdate",
            },
            Username: {
                required: "Please provide Student ID",
                remote: "Student ID is already taken"
            },
            Password: {
                required: "Please provide password",
                minlength: "Password must be minimum of 8 characters!",
                passwordRegex: "Password must include uppercase, number and special character"
            },
            Confirmpassword: {
                required: "Please Confirm password",
                equalTo: "Password didn't match! Please Try Again"
            }

        },

        submitHandler: function (form) {
            var url = $(form).attr("action");
            var data = $(form).serialize();
            $.ajax({
                url: url,
                type: "POST",
                data: data,
                contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
                success: function (res) {
                    if (res == true) {
                        alert("Something went wrong");
                    }
                    else {
                        
                        window.location.href = "Home/Login";
                    }
                },
                error: function (res) {

                }
            });

        }


    });

    jQuery.validator.addMethod("passwordRegex", function (value, element) {
        var regex = new RegExp("^((?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*]))");
        var key = value;

        if (!regex.test(key)) {
            return false;
        }
        return true;
    });


});