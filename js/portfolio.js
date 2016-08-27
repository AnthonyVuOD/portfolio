var app = angular
  .module('portfolioModule',['ngRoute','ngAnimate'])
  .config(function($routeProvider){
    $routeProvider.caseInsensitiveMatch= true;
    $routeProvider
      .when("/home",{
        templateUrl:'templates/home.html',
        controller:'homeCTRL'
      })
      .when("/about",{
        templateUrl:'templates/about.html',
        controller:'aboutCTRL'
      })
      .when("/portfolio",{
        templateUrl:'templates/portfolio.html',
        controller:'portfolioCTRL'
      })
      .when("/workflow",{
        templateUrl:'templates/workflow.html',
        controller:'workflowCTRL'
      })
      .when("/contact",{
        templateUrl:'templates/contact.html',
        controller:'contactCTRL'
      })
      .otherwise({
        redirectTo:"/home"
      })
  })
  .controller('indexCTRL', function($rootScope, $scope, $location){
    $rootScope.$on('$routeChangeSuccess', function(){
      $scope.landingPage = $location.path() === '/home';
    });
  })
  .controller('homeCTRL', function($scope, $timeout){
    $scope.fade=false;
      $timeout(function(){
        $scope.fade=true;
      },550);
  })
  .controller('aboutCTRL', function($scope, $timeout){
    $scope.fade=false;
      $timeout(function(){
        $scope.fade=true;
      },400);
  })
  .controller('portfolioCTRL', function($scope, $timeout){
    $scope.items = [
      {project: "project 1", color: "purple", delay: ".1s"},
      {project: "project 2", color: "green", delay: ".2s"},
      {project: "project 3", color: "red", delay: ".3s"},
      {project: "project 4", color: "blue", delay: ".4s"}
    ];
    $scope.fade=false;
      $timeout(function(){
        $scope.fade=true;
      },400);
  })
  .controller('workflowCTRL', function($scope, $timeout){
    $scope.fade=false;
      $timeout(function(){
        $scope.fade=true;
      },400);
  })
  .controller('contactCTRL',function($scope, $timeout){
    $scope.fade=false;
      $timeout(function(){
        $scope.fade=true;
      },400);
  });
