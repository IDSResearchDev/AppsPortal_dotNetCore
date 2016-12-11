// appsController.js

(function () {

    "use strict";

    // Getting the existing Module
    
    angular.module("appsportal")
        .controller("appsController", appsController);

    function appsController($scope, appsService) {
       
        $scope.applications = [];

        $scope.isBusy = true;

        var onAppsComplete = function (data) {
            $scope.applications = data;
        };

        var onError = function (reason) {
            $scope.errorMessage = "Failed to load data: " + reason;
        };


        appsService.getAllApps()
            .then(onAppsComplete, onError)
            .finally(function () {
                $scope.isBusy = false;
            });

        //appData.set($scope.applications);

        //$scope.onView = function (title) {
        //    var app = $.grep($scope.applications, function (e) {
        //        return e.title === title;
        //    });

        //    appData.set(app);
        //    $location.path("/editor/"+title);
        //};
    }

})();