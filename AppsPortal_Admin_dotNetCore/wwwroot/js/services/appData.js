(function () {

    var appData = function () {

        var savedData = {};
        function set(data){
            savedData = data;
        }

        function get() {
            return savedData;
        }

        return {
            set: set,
            get: get
        };
    };

    var module = angular.module("appsportal");

    module.factory("appData", appData);

}());