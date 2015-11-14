var usersData = (function () {
    var LOCAL_STORAGE_USERNAME_KEY = 'signed-in-user-username',
    LOCAL_STORAGE_AUTHKEY_KEY = 'signed-in-user-auth-key',
    LOCAL_STORAGE_AUTHKEY_KEY_TOKEN = 'signed-in-user-auth-key-token';
    LOCAL_STORAGE_AUTHKEY_KEY_TOKEN_TYPE = 'signed-in-user-auth-key-token-type';

    var serverURLforUser = URL + 'api/user';

    //01. Create User (POST) - api/user
    function register(user) {
        var reqUser = {
            username: user.username,
            password: CryptoJS.SHA1(user.username + user.password).toString()

        };

        return jsonRequester.post(serverURLforUser, {
            data: reqUser
        })
          .then(function (resp) {
              var user = resp.result;
              localStorage.setItem(LOCAL_STORAGE_USERNAME_KEY, user.username);
              localStorage.setItem(LOCAL_STORAGE_AUTHKEY_KEY, user.authKey);
              return {
                  username: resp.result.username
              };
          });
    }

    //02. Update User by ID - (PUT) - api/user/{id}
    function userUpdateById(id, user) {
        var options = {
            data: user,
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY)
            }
        };
        return jsonRequester.put(serverURLforUser + id, options)
          .then(function (resp) {
              return resp.result;
          });
    }

    //03. Delete User by ID - (DELETE) - api/user/{id}
    function userDeleteById(id, user) {
        var options = {
            data: user,
            headers: {
                'Authorization': localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY_TOKEN_TYPE)+' '+localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY_TOKEN)
            }
        };
        return jsonRequester.delete(serverURLforUser + id, options)
          .then(function (resp) {
              return resp.result;
          });
    }

    //04. Delete User by Email - (DELETE) - api/user/{email}
    function userDeleteByEmail(email, user) {
        var options = {
            data: user,
            headers: {
                'Authorization': localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY_TOKEN_TYPE) + ' ' + localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY_TOKEN)
            }
        };
        return jsonRequester.delete(serverURLforUser + email, options)
          .then(function (resp) {
              return resp.result;
          });
    }

    //05. Get User by ID - (GET) - api/user/{id}
    function usersGetById(id) {
        return jsonRequester.get(serverURLforUser + id)
          .then(function (res) {
              return res.result;
          });
    }

    //06. Get User by Apartment Number - (GET) - api/user/{apartment-number}
    function usersGetByApartmentNumber(number) {
        return jsonRequester.get(serverURLforUser + number)
          .then(function (res) {
              return res.result;
          });
    }

    //07. Get all Users - (GET) - api/user
    function usersGet() {
        return jsonRequester.get(serverURLforUser)
          .then(function (res) {
              return res.result;
          });
    }

    function signIn(user) {
        var reqUser = {
            username: user.username,
            password: CryptoJS.SHA1(user.username + user.password).toString(),
            grant_type:password
        };

        var options = {
            data: reqUser
        };

        return jsonRequester.put(URL + '/token', options)
          .then(function (resp) {
              var user = resp.result;
              localStorage.setItem(LOCAL_STORAGE_USERNAME_KEY, user.userName);
              localStorage.setItem(LOCAL_STORAGE_AUTHKEY_KEY, user.authKey);
              localStorage.setItem(LOCAL_STORAGE_AUTHKEY_KEY_TOKEN, user.access_token);
              localStorage.setItem(LOCAL_STORAGE_AUTHKEY_KEY_TOKEN_TYPE, user.token_type);
              return user;
          });
    }

    function signOut() {
        var promise = new Promise(function (resolve, reject) {
            localStorage.removeItem(LOCAL_STORAGE_USERNAME_KEY);
            localStorage.removeItem(LOCAL_STORAGE_AUTHKEY_KEY);
            localStorage.removeItem(LOCAL_STORAGE_AUTHKEY_KEY_TOKEN);
            localStorage.removeItem(LOCAL_STORAGE_AUTHKEY_KEY_TOKEN_TYPE);
            resolve();
        });
        return promise;
    }

    function hasUser() {
        return !!localStorage.getItem(LOCAL_STORAGE_USERNAME_KEY) &&
          !!localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY);
    }



    return {
        users: {
            signIn: signIn,
            signOut: signOut,
            register: register,
            hasUser: hasUser,
            get: usersGet,
            userUpdateById: userUpdateById,
            userDeleteById: userDeleteById,
            userDeleteByEmail: userDeleteByEmail,
            usersGetById: usersGetById,
            usersGetByApartmentNumber: usersGetByApartmentNumber
        }
    };
}());