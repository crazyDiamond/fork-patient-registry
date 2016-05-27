'use strict';

/**
 * @ngdoc overview
 * @name patientRegistryApp
 * @description
 * # patientRegistryApp
 *
 * Main module of the application.
 */
angular
  .module('patientRegistryApp', [
    'ngAnimate',
    'ngCookies',
    'ngResource',
    'ngRoute',
    'ngSanitize',
    'ngTouch'
  ])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'views/main.html',
        controller: 'MainCtrl',
        controllerAs: 'main'
      })
      .when('/entry', {
        templateUrl: 'views/entry.html',
        controller: 'EntryCtrl',
        controllerAs: 'entry'
      })
      .when('/users', {
        templateUrl: 'views/users.html',
        controller: 'UsersCtrl',
        controllerAs: 'users'
      })
      .otherwise({
        redirectTo: '/'
      });
  });
