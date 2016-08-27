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
    })
  })
  .controller('homeCTRL', function($scope, $timeout){
    $scope.fade=false;
      $timeout(function(){
        $scope.fade=true
      },600)
  })
  .controller('aboutCTRL', function($scope){

  })
  .controller('portfolioCTRL', function($scope){

  })
  .controller('workflowCTRL', function($scope){

  })
  .controller('contactCTRL',function($scope){

  });
