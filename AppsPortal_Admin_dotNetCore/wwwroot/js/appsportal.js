// app-portal.js

(function () {

    "use strict";

    // Creating the Module
    angular.module("appsportal", ["ngRoute"])
        .config(function ($routeProvider, $locationProvider) {
            $routeProvider.when("/", {
                controller: "appsController",
                templateUrl: "/views/appsView.html"
            }).when("/editor/:appTitle", {
                controller: "appsEditorController",
                templateUrl: "/views/appsEditorView.html"
            }).when("/slidelist", {
                controller: "slidesController",
                templateUrl: "/views/slidesView.html"
            });
            
            $routeProvider.otherwise({ redirectTo: "/" });

            //$locationProvider.html5Mode({
            //    enabled: true
            //    //requireBase: false
            //});
        });
})();
