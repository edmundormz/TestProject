(function (angular) {
    "use strict";

    angular.module('app',
        [
            'ngRoute',
            'ui.bootstrap',
        ]).config([
            '$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
                $routeProvider
                    .when('/',
                    {
                        templateUrl: '/views/home.html',
                        title: 'Home'
                    })
                    .when('/AddNew',
                    {
                        templateUrl: 'views/add.html'
                    })
                    .when('/Edit/:id',
                    {
                        templateUrl: 'views/edit.html'
                    }).
                when('/Add', {
                    templateUrl: 'views/add.html'
                });
                $routeProvider.otherwise({
                    redirectTo: '/'
                });
                $locationProvider.html5Mode(true);
            }]).controller('HomeCtrl', function ($scope, $http, $location, $routeParams, $route) {
                $scope.rows = [];
                $http.get('/api/toys').then(function (response) {
                    $scope.rows = response.data;
                });
                $scope.edit = function (id) {
                    $location.path('/Edit/' + id);
                }
                $scope.delete = function (id) {
                    $http.delete('/api/toys/' + id).then(function () {
                        alert("Toy deleted");
                        $route.reload();
                    });
                }
            }).controller('EditCtrl', function ($scope, $http, $location, $routeParams) {
                $scope.toy = [];
                $http.get('/api/toys/' + $routeParams.id).then(function (response) {
                    $scope.toy = response.data;
                });
                $scope.submit = function () {
                    var toy = {
                        Id: $routeParams.id,
                        Name: $scope.toy.Name,
                        AgeDescription: $scope.toy.AgeDescription,
                        Price: $scope.toy.Price,
                        Company: $scope.toy.Company,
                        Description: $scope.toy.Description
                    };
                    $http.put('/api/toys', toy).then(function () {
                        $location.path("/");
                    });
                }
            }).controller('AddCtrl', function ($scope, $location, $http) {
                $scope.submit = function () {
                    var toy = {
                        Name: $scope.toy.Name,
                        AgeDescription: $scope.toy.AgeDescription,
                        Price: $scope.toy.Price,
                        Company: $scope.toy.Company,
                        Description: $scope.toy.Description
                    };
                    $http.post('/api/toys', toy).then(function () {
                        $location.path("/");
                    });
                }
            });
})(window.angular);