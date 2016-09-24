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
      .when("/cv",{
        templateUrl:'templates/cv.html',
        controller:'cvCTRL'
      })
      .when("/contact",{
        templateUrl:'templates/contact.html',
        controller:'contactCTRL'
      })
      .otherwise({
        redirectTo:"/home"
      })
  })
  .controller('indexCTRL', function($rootScope, $scope, $location, $timeout){
    $rootScope.$on('$routeChangeSuccess', function(){
      $scope.landingPage = $location.path() === '/home';
    });

    $scope.fade=false;
    $timeout(function(){
      $scope.fade=true;
    },200);
  })
  .controller('homeCTRL', function($scope, $timeout, $location){
    $scope.fade=false;
    $timeout(function(){
      $scope.fade=true;
    },500);

    $scope.changePath = function(path) {
      $location.path (path);
    };
  })
  .controller('aboutCTRL', function($scope, $timeout){
    $scope.fade=false;
    $timeout(function(){
      $scope.fade=true;
    },400);
  })
  .controller('portfolioCTRL', function($scope, $timeout){
    $scope.items = [
      {project: "Greenbelt Climbing Routes", color: "purple", delay: ".1s"},
      {project: "Travis Perkins Photography", color: "green", delay: ".2s"},
      {project: "How Much House?", color: "red", delay: ".3s"},
      {project: "Vu Realty", color: "blue", delay: ".4s"}
    ];

    $scope.fade=false;
    $timeout(function(){
      $scope.fade=true;
    },400);
  })
  .controller('cvCTRL', function($scope, $timeout){
    $scope.fade=false;
    $timeout(function(){
      $scope.fade=true;
    },400);
  })
  .controller('contactCTRL', function($scope, $timeout){
    $scope.contactItems = [
      {link:'https://www.linkedin.com/in/anthony-vu-257a417?trk=nav_responsive_tab_profile', photo:'photos/linkedInicon.png'},
      {link:'https://github.com/AnthonyVuOD', photo:'photos/githubIcon.png'},
      {link:'https://www.facebook.com/profile.php?id=2007303', photo:'photos/facebookIcon.png'},
      {link:'mailto:AnthonyVuOD@gmail.com', photo:'photos/gmailIcon.png'}
    ];

    $scope.fade=false;
    $timeout(function(){
      $scope.fade=true;
    },400);
  });
