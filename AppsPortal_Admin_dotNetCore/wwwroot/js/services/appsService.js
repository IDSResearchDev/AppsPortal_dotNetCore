(function () {

    var appsService = function ($http) {

        var getAllApps = function () {
            return $http.get("/api/apps")
                        .then(function (response) {
                            return response.data;
                        });
        };

        var getApp = function (appTitle) {
            return $http.get("/api/apps/" + appTitle)
                        .then(function (response) {
                            return response.data;
                        });
        };

        return {
            getAllApps: getAllApps,
            getApp: getApp
        };
    };

    var module = angular.module("appsportal");

    module.factory("appsService", appsService);

}());