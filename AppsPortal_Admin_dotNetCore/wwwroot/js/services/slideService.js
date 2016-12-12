(function () {

    var slideService = function ($http) {

        var getAllSlides = function () {
            return $http.get("/api/slides")
                        .then(function (response) {
                            return response.data;
                        });
        };

        var getSlide = function (slideTitle) {
            return $http.get("/api/slides/" + slideTitle)
                        .then(function (response) {
                            return response.data;
                        });
        };

        return {
            getAllSlides: getAllSlides,
            getSlide: getSlide
        };
    };

    var module = angular.module("appsportal");

    module.factory("slideService", slideService);

}());