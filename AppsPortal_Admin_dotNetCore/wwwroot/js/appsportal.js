// app-portal.js

(function () {

    "use strict";

    // Creating the Module
    angular.module("appsportal", ["ngRoute"])
        .config(function ($routeProvider) {
            $routeProvider.when("/apps", {
                controller: "appsController",
                templateUrl: "/views/appsView.html"
            }).when("/editor/:appTitle", {
                controller: "appsEditorController",
                templateUrl: "/views/appsEditorView.html"
            });
            
            $routeProvider.otherwise({ redirectTo: "/" });
        });
})();
