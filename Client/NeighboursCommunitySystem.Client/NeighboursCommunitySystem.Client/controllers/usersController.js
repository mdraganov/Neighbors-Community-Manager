var usersController = function () {

    function signIn(user) {
        $('#modified-login-btn').on('click', function () {
            var user = {
                username: $('#Email').val(),
                password: $('#Password').val()
            };

            data.usersData.signIn(user)
              .then(function () {
                  //toastr.success('User registered!');
                  context.redirect('#/');
                  document.location.reload(true);
              });
        });
        
    }


    function register(context) {
        templates.get('register')
          .then(function (template) {
              //context.$element().html(template());

              $('#modified-login-btn').on('click', function () {
                  var user = {
                      username: $('#Email').val(),
                      password: $('#Password').val()
                  };

                  data.usersData.register(user)
                    .then(function () {
                        //toastr.success('User registered!');
                        context.redirect('#/');
                        document.location.reload(true);
                    });
              });
          });
    }

    return {
        register: register,
        signIn: signIn
    };
}();