// appsController.js

(function () {

    "use strict";

    // Getting the existing Module

    angular.module("appsportal")
        .controller("slidesController", slidesController);

    function slidesController($scope, slideService) {

        $scope.slides = [];

        $scope.isBusy = true;

        var onSlideComplete = function (data) {
            $scope.slides = data;
        };

        var onError = function (reason) {
            $scope.errorMessage = "Failed to load data: " + reason;
        };


        slideService.getAllSlides()
            .then(onSlideComplete, onError)
            .finally(function () {
                $scope.isBusy = false;
            });
    }

})();