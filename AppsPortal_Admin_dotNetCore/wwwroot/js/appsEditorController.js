// appsEditorController.js

(function () {
    "use strict";

    angular.module("appsportal")
        .controller("appsEditorController", appsEditorController);

    function appsEditorController($scope, $routeParams, appsService) {

        $scope.app = {};
        $scope.errorMessage = "";

        var onAppComplete = function (data) {
            $scope.app = data;
        };

        var onError = function (reason) {
            $scope.errorMessage = "Failed to load data: " + reason;
        };

        appsService.getApp($routeParams.appTitle)
                  .then(onAppComplete, onError);
    }


})();