var app = angular
  .module('portfolioModule',['ngRoute','ngAnimate'])
  // will indicates what templated are used
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
    // fade controls delay when images and headers appear
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
      {project: "Greenbelt Climbing Routes", link:"https://anthonyvuod.github.io/GreenbeltClimbingRoutes/", delay: ".1s", photo:"photos/greenbeltSS.jpg"},
      {project: "Travis Perkins Photography", link:"https://anthonyvuod.github.io/TravisPerkinsPhotography/", delay: ".2s", photo:"photos/travisPerkinsSS2.jpg"},
      {project: "How Much House?", link:"https://anthonyvuod.github.io/HowMuchHouse/", delay: ".3s", photo:"photos/houseSS2.jpg"},
      {project: "Vu Properties", link:"https://anthonyvuod.github.io/VuProperties/", delay: ".4s", photo:"photos/vuPropertiesSS.jpg"}
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
      {link:'https://www.linkedin.com/in/anthony-vu-257a417?trk=nav_responsive_tab_profile', photo:'photos/linkedInIcon2.png'},
      {link:'https://github.com/AnthonyVuOD', photo:'photos/gitHubIcon2.png'},
      // {link:'https://www.facebook.com/profile.php?id=2007303', photo:'photos/facebookIcon.png'},
      {link:'mailto:AnthonyVuOD@gmail.com', photo:'photos/gmailIcon2.png'}
    ];

    $scope.fade=false;
    $timeout(function(){
      $scope.fade=true;
    },400);
  });
