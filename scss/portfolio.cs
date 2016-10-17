body {
  margin: 0;
  padding: 0;
  font-size: 16px;
  background-color: #363636;
  height: 100vh; }

#outerWrapper {
  position: absolute;
  width: 90%;
  max-width: 1150px;
  min-width: 1150px;
  height: 80vh;
  max-height: 530px;
  min-height: 500px;
  margin: auto;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0; }

#header {
  width: 100%;
  height: 10%;
  position: absolute;
  clear: both; }
  #header h3 {
    position: absolute;
    bottom: -35px;
    right: 0;
    font-size: 2em;
    padding-right: 2%;
    color: #e3e3e3;
    font-family: "Raleway", sans-serif; }
    #header h3 span {
      font-size: .75em;
      padding-left: 15px;
      font-family: "Josefin Sans", sans-serif; }

#menu {
  width: 100%;
  height: 10%;
  position: absolute;
  clear: both; }
  #menu ul {
    position: absolute;
    right: 0px;
    bottom: -15px;
    width: 96%; }
    #menu ul li {
      float: right;
      padding-right: 3%;
      list-style-type: none;
      position: relative; }
      #menu ul li a {
        margin-top: 50px;
        text-decoration: none;
        color: #e3e3e3;
        font-size: 1.25em;
        font-family: "Raleway", sans-serif; }
        #menu ul li a:hover {
          text-decoration: underline; }
    #menu ul span {
      float: left;
      margin-left: -2%;
      margin-top: -25px; }

#avLogo {
  width: 50px;
  height: auto;
  margin-bottom: -31px; }

.fadeHeaders.ng-enter {
  -webkit-transition: .75s linear all;
  -moz-transition: .75s linear all;
  -o-transition: .75s linear all;
  transition: .75s linear all;
  opacity: 0; }
.fadeHeaders.ng-enter.ng-enter-active {
  -webkit-transition-delay: .75s;
  opacity: 1; }
.fadeHeaders.ng-leave {
  -webkit-transition: 0.5s linear all;
  -moz-transition: 0.5s linear all;
  -o-transition: 0.5s linear all;
  transition: 0.5s linear all;
  opacity: 1; }
.fadeHeaders.ng-leave.ng-leave-active {
  opacity: 0; }

#innerWrapper {
  width: 100%;
  height: 90%;
  position: absolute;
  top: 10%; }
  #innerWrapper.ng-leave {
    -webkit-transition: 0.5s linear all;
    -moz-transition: 0.5s linear all;
    -o-transition: 0.5s linear all;
    transition: 0.5s linear all;
    opacity: 1; }
  #innerWrapper.ng-leave.ng-leave-active {
    opacity: 0; }

#copyright {
  position: absolute;
  bottom: 7%;
  right: 7%;
  color: #e3e3e3;
  font-family: "Josefin Sans", sans-serif; }

#homePhoto {
  position: relative;
  float: left;
  height: 99.8%;
  width: 33%;
  background-color: red;
  margin: 1px 1px 1px 1px; }
  #homePhoto.ng-enter {
    -webkit-transition: 0.65s linear all;
    -moz-transition: 0.65s linear all;
    -o-transition: 0.65s linear all;
    transition: 0.65s linear all;
    -webkit-transform: translateX(-35px);
    -moz-transform: translateX(-35px);
    -o-transform: translateX(-35px);
    transform: translateX(-35px);
    opacity: 0; }
  #homePhoto.ng-enter.ng-enter-active {
    -webkit-transform: translateX(0);
    -moz-transform: translateX(0);
    -o-transform: translateX(0);
    transform: translateX(0);
    opacity: 1; }
  #homePhoto.ng-leave {
    -webkit-transition: 0.5s linear all;
    -moz-transition: 0.5s linear all;
    -o-transition: 0.5s linear all;
    transition: 0.5s linear all;
    opacity: 1; }
  #homePhoto.ng-leave.ng-leave-active {
    opacity: 0; }

#homeAbout {
  background-image: url(../photos/rope3.png);
  background-position: bottom left;
  background-repeat: no-repeat;
  background-size: cover; }
  #homeAbout.ng-enter {
    -webkit-transition: 0.65s linear all;
    -moz-transition: 0.65s linear all;
    -o-transition: 0.65s linear all;
    transition: 0.65s linear all;
    -webkit-transform: translateY(-30px);
    -moz-transform: translateY(-30px);
    -o-transform: translateY(-30px);
    transform: translateY(-30px);
    opacity: 0; }
  #homeAbout.ng-enter.ng-enter-active {
    -webkit-transform: translateY(0);
    -moz-transform: translateY(0);
    -o-transform: translateY(0);
    transform: translateY(0);
    opacity: 1; }
  #homeAbout.ng-leave {
    -webkit-transition: 0.5s linear all;
    -moz-transition: 0.5s linear all;
    -o-transition: 0.5s linear all;
    transition: 0.5s linear all;
    opacity: 1; }
  #homeAbout.ng-leave.ng-leave-active {
    opacity: 0; }

#homePortfolio {
  background-image: url(../photos/computer2.png);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover; }
  #homePortfolio.ng-enter {
    -webkit-transition: 0.65s linear all;
    -moz-transition: 0.65s linear all;
    -o-transition: 0.65s linear all;
    transition: 0.65s linear all;
    -webkit-transform: translate(30px, -30px);
    -moz-transform: translate(30px, -30px);
    -o-transform: translate(30px, -30px);
    transform: translate(30px, -30px);
    opacity: 0; }
  #homePortfolio.ng-enter.ng-enter-active {
    -webkit-transform: translate(0);
    -moz-transform: translate(0);
    -o-transform: translate(0);
    transform: translate(0);
    opacity: 1; }
  #homePortfolio.ng-leave {
    -webkit-transition: 0.5s linear all;
    -moz-transition: 0.5s linear all;
    -o-transition: 0.5s linear all;
    transition: 0.5s linear all;
    opacity: 1; }
  #homePortfolio.ng-leave.ng-leave-active {
    opacity: 0; }

#homeCv {
  background-image: url(../photos/guitar.png);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover; }
  #homeCv.ng-enter {
    -webkit-transition: 0.65s linear all;
    -moz-transition: 0.65s linear all;
    -o-transition: 0.65s linear all;
    transition: 0.65s linear all;
    -webkit-transform: translateY(30px);
    -moz-transform: translateY(30px);
    -o-transform: translateY(30px);
    transform: translateY(30px);
    opacity: 0; }
  #homeCv.ng-enter.ng-enter-active {
    -webkit-transform: translateY(0);
    -moz-transform: translateY(0);
    -o-transform: translateY(0);
    transform: translateY(0);
    opacity: 1; }
  #homeCv.ng-leave {
    -webkit-transition: 0.5s linear all;
    -moz-transition: 0.5s linear all;
    -o-transition: 0.5s linear all;
    transition: 0.5s linear all;
    opacity: 1; }
  #homeCv.ng-leave.ng-leave-active {
    opacity: 0; }

#homeContact {
  background-color: blue; }
  #homeContact.ng-enter {
    -webkit-transition: 0.65s linear all;
    -moz-transition: 0.65s linear all;
    -o-transition: 0.65s linear all;
    transition: 0.65s linear all;
    -webkit-transform: translate(25px, 25px);
    -moz-transform: translate(25px, 25px);
    -o-transform: translate(25px, 25px);
    transform: translate(25px, 25px);
    opacity: 0; }
  #homeContact.ng-enter.ng-enter-active {
    -webkit-transform: translate(0);
    -moz-transform: translate(0);
    -o-transform: translate(0);
    transform: translate(0);
    opacity: 1; }
  #homeContact.ng-leave {
    -webkit-transition: 0.5s linear all;
    -moz-transition: 0.5s linear all;
    -o-transition: 0.5s linear all;
    transition: 0.5s linear all;
    opacity: 1; }
  #homeContact.ng-leave.ng-leave-active {
    opacity: 0; }

.homeLinks {
  position: relative;
  float: left;
  width: 33%;
  height: 49.75%;
  margin: 1px 1px 1px 1px; }
  .homeLinks:hover {
    cursor: pointer; }
  .homeLinks h2 {
    position: absolute;
    font-size: 1.5em;
    bottom: -3%;
    right: 5%;
    font-family: "Raleway", sans-serif;
    color: black; }

#aboutPhoto {
  float: left;
  width: 32%;
  height: 100%;
  background-image: url("../photos/aboutPhoto2.png");
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  position: relative; }
  #aboutPhoto h2 {
    position: absolute;
    font-size: 1.5em;
    bottom: -2%;
    right: 5%;
    font-family: "Raleway", sans-serif;
    color: #e3e3e3; }
  #aboutPhoto.ng-enter {
    -webkit-transition: 0.65s linear all;
    -moz-transition: 0.65s linear all;
    -o-transition: 0.65s linear all;
    transition: 0.65s linear all;
    -webkit-transform: translateX(-35px);
    -moz-transform: translateX(-35px);
    -o-transform: translateX(-35px);
    transform: translateX(-35px);
    opacity: 0; }
  #aboutPhoto.ng-enter.ng-enter-active {
    -webkit-transform: translateX(0);
    -moz-transform: translateX(0);
    -o-transform: translateX(0);
    transform: translateX(0);
    opacity: 1; }
  #aboutPhoto.ng-leave {
    -webkit-transition: 0.5s linear all;
    -moz-transition: 0.5s linear all;
    -o-transition: 0.5s linear all;
    transition: 0.5s linear all;
    opacity: 1; }
  #aboutPhoto.ng-leave.ng-leave-active {
    opacity: 0; }

#aboutContent {
  float: left;
  width: 67%;
  height: 100%;
  background-color: #e3e3e3;
  position: relative;
  margin: 0px 0px 0px 2px; }
  #aboutContent #aboutDiv {
    position: relative;
    width: 100%; }
    #aboutContent #aboutDiv h3 {
      width: 80%;
      margin: 8% auto 0% auto;
      font-family: "Josefin Sans", sans-serif;
      font-size: 1.5em;
      color: #363636;
      position: relative; }
    #aboutContent #aboutDiv p {
      width: 80%;
      margin: 4% auto;
      font-family: "Josefin Sans", sans-serif;
      font-size: 1.25em;
      color: #363636; }
      #aboutContent #aboutDiv p span {
        margin-left: 20px; }
    #aboutContent #aboutDiv img {
      width: 33%;
      height: auto;
      float: right;
      margin-right: 15%; }
  #aboutContent.ng-enter {
    -webkit-transition: 0.65s linear all;
    -moz-transition: 0.65s linear all;
    -o-transition: 0.65s linear all;
    transition: 0.65s linear all;
    -webkit-transform: translateX(35px);
    -moz-transform: translateX(35px);
    -o-transform: translateX(35px);
    transform: translateX(35px);
    opacity: 0; }
  #aboutContent.ng-enter.ng-enter-active {
    -webkit-transform: translateX(0);
    -moz-transform: translateX(0);
    -o-transform: translateX(0);
    transform: translateX(0);
    opacity: 1; }
  #aboutContent.ng-leave {
    -webkit-transition: 0.5s linear all;
    -moz-transition: 0.5s linear all;
    -o-transition: 0.5s linear all;
    transition: 0.5s linear all;
    opacity: 1; }
  #aboutContent.ng-leave.ng-leave-active {
    opacity: 0; }

.projects {
  float: left;
  width: 49.5%;
  height: 49.5%;
  position: relative;
  background-position: top;
  background-repeat: no-repeat;
  background-size: cover;
  margin: 1px 1px 1px 1px; }
  .projects.ng-enter {
    -webkit-transition: .55s linear all;
    -moz-transition: .55s linear all;
    -o-transition: .55s linear all;
    transition: .55s linear all;
    opacity: 0; }
  .projects.ng-enter.ng-enter-active {
    opacity: 1; }
  .projects h2 {
    position: absolute;
    bottom: -7%;
    right: 1.5%;
    font-family: "Raleway", sans-serif;
    color: #e3e3e3;
    font-size: 1.5em;
    text-shadow: -1px 0 black, 0 1px black, 1px 0 black, 0 -1px black; }

#cvPhoto {
  float: left;
  width: 32%;
  height: 100%;
  background-color: purple;
  position: relative; }
  #cvPhoto h2 {
    position: absolute;
    bottom: -2%;
    right: 5%;
    font-family: "Raleway", sans-serif;
    color: #363636;
    font-size: 1.5em; }
  #cvPhoto.ng-enter {
    -webkit-transition: 0.65s linear all;
    -moz-transition: 0.65s linear all;
    -o-transition: 0.65s linear all;
    transition: 0.65s linear all;
    -webkit-transform: translateX(-35px);
    -moz-transform: translateX(-35px);
    -o-transform: translateX(-35px);
    transform: translateX(-35px);
    opacity: 0; }
  #cvPhoto.ng-enter.ng-enter-active {
    -webkit-transform: translateX(0);
    -moz-transform: translateX(0);
    -o-transform: translateX(0);
    transform: translateX(0);
    opacity: 1; }
  #cvPhoto.ng-leave {
    -webkit-transition: 0.5s linear all;
    -moz-transition: 0.5s linear all;
    -o-transition: 0.5s linear all;
    transition: 0.5s linear all;
    opacity: 1; }
  #cvPhoto.ng-leave.ng-leave-active {
    opacity: 0; }

#cvContent {
  float: left;
  width: 67%;
  height: 100%;
  background-color: #e3e3e3;
  margin: 0px 0px 0px 2px;
  position: relative; }
  #cvContent.ng-enter {
    -webkit-transition: 0.65s linear all;
    -moz-transition: 0.65s linear all;
    -o-transition: 0.65s linear all;
    transition: 0.65s linear all;
    -webkit-transform: translateX(35px);
    -moz-transform: translateX(35px);
    -o-transform: translateX(35px);
    transform: translateX(35px);
    opacity: 0; }
  #cvContent.ng-enter.ng-enter-active {
    -webkit-transform: translateX(0);
    -moz-transform: translateX(0);
    -o-transform: translateX(0);
    transform: translateX(0);
    opacity: 1; }
  #cvContent.ng-leave {
    -webkit-transition: 0.5s linear all;
    -moz-transition: 0.5s linear all;
    -o-transition: 0.5s linear all;
    transition: 0.5s linear all;
    opacity: 1; }
  #cvContent.ng-leave.ng-leave-active {
    opacity: 0; }
  #cvContent #outerDivCV {
    width: 95%;
    height: 90%;
    margin: auto;
    position: relative;
    top: 50%;
    transform: translateY(-50%);
    font-family: "Josefin Sans", sans-serif;
    font-size: 1.25em;
    color: #363636; }
    #cvContent #outerDivCV .innerDivCV {
      float: left;
      width: 50%;
      height: 40%;
      text-align: center; }
      #cvContent #outerDivCV .innerDivCV h2 {
        font-family: "Josefin Sans", sans-serif;
        font-size: 1.5em;
        color: #363636;
        text-decoration: underline; }
      #cvContent #outerDivCV .innerDivCV table {
        width: 92.5%;
        margin: -4% auto; }
        #cvContent #outerDivCV .innerDivCV table .leftColumn {
          text-align: left; }
        #cvContent #outerDivCV .innerDivCV table .rightColumn {
          text-align: right; }
        #cvContent #outerDivCV .innerDivCV table span {
          color: black;
          font-weight: bolder; }
    #cvContent #outerDivCV .innerDivCValt {
      float: left;
      width: 100%;
      height: 60%;
      text-align: center;
      position: relative; }
      #cvContent #outerDivCV .innerDivCValt h2 {
        font-family: "Josefin Sans", sans-serif;
        font-size: 1.5em;
        color: #363636;
        text-decoration: underline; }
      #cvContent #outerDivCV .innerDivCValt table {
        width: 50%;
        margin: -4% auto; }
        #cvContent #outerDivCV .innerDivCValt table ul {
          list-style-type: none;
          text-align: left; }
      #cvContent #outerDivCV .innerDivCValt a {
        margin: 4% auto;
        display: block;
        width: 10%; }
        #cvContent #outerDivCV .innerDivCValt a img {
          width: 40px;
          height: auto; }
        #cvContent #outerDivCV .innerDivCValt a:hover {
          -webkit-filter: drop-shadow(0px 5px 4px black);
          filter: drop-shadow(0px 5px 4px black); }

#contactPhoto {
  float: left;
  width: 32%;
  height: 100%;
  background-image: url("../photos/wireFrameSketch5.png");
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  position: relative; }
  #contactPhoto h2 {
    position: absolute;
    bottom: -2%;
    right: 5%;
    font-family: "Raleway", sans-serif;
    color: #363636;
    font-size: 1.5em; }
  #contactPhoto.ng-enter {
    -webkit-transition: 0.65s linear all;
    -moz-transition: 0.65s linear all;
    -o-transition: 0.65s linear all;
    transition: 0.65s linear all;
    -webkit-transform: translateX(-35px);
    -moz-transform: translateX(-35px);
    -o-transform: translateX(-35px);
    transform: translateX(-35px);
    opacity: 0; }
  #contactPhoto.ng-enter.ng-enter-active {
    -webkit-transform: translateX(0);
    -moz-transform: translateX(0);
    -o-transform: translateX(0);
    transform: translateX(0);
    opacity: 1; }
  #contactPhoto.ng-leave {
    -webkit-transition: 0.5s linear all;
    -moz-transition: 0.5s linear all;
    -o-transition: 0.5s linear all;
    transition: 0.5s linear all;
    opacity: 1; }
  #contactPhoto.ng-leave.ng-leave-active {
    opacity: 0; }

#contactContent {
  float: left;
  width: 67%;
  height: 100%;
  position: relative;
  background-color: #e3e3e3;
  margin: 0px 0px 0px 2px; }
  #contactContent.ng-enter {
    -webkit-transition: 0.65s linear all;
    -moz-transition: 0.65s linear all;
    -o-transition: 0.65s linear all;
    transition: 0.65s linear all;
    -webkit-transform: translateX(35px);
    -moz-transform: translateX(35px);
    -o-transform: translateX(35px);
    transform: translateX(35px);
    opacity: 0; }
  #contactContent.ng-enter.ng-enter-active {
    -webkit-transform: translateX(0);
    -moz-transform: translateX(0);
    -o-transform: translateX(0);
    transform: translateX(0);
    opacity: 1; }
  #contactContent.ng-leave {
    -webkit-transition: 0.5s linear all;
    -moz-transition: 0.5s linear all;
    -o-transition: 0.5s linear all;
    transition: 0.5s linear all;
    opacity: 1; }
  #contactContent.ng-leave.ng-leave-active {
    opacity: 0; }
  #contactContent div {
    position: relative;
    height: 60px;
    width: 400px;
    margin: auto;
    top: 50%;
    transform: translateY(-50%); }
    #contactContent div .socialMediaLinks {
      display: block;
      height: 60px;
      width: 25%;
      position: relative;
      float: left;
      background-position: center;
      background-repeat: no-repeat;
      background-size: auto 100%;
      -webkit-filter: brightness(75%);
      /* Chrome, Safari, Opera */
      filter: brightness(75%); }
      #contactContent div .socialMediaLinks:hover {
        -webkit-filter: brightness(100%);
        /* Chrome, Safari, Opera */
        filter: brightness(100%);
        -webkit-filter: drop-shadow(0px 6px 5px black);
        filter: drop-shadow(0px 6px 5px black); }

@media screen and (max-width: 800px) {
  body {
    font-size: 16px;
    height: auto; }

  #outerWrapper {
    width: 65%;
    height: auto;
    float: left;
    max-width: none;
    min-width: inherit;
    max-height: none; }

  #header {
    height: 14%; }
    #header h3 {
      bottom: -15px;
      font-size: 1.75em; }

  #menu {
    height: 14%; }
    #menu ul {
      right: 0px;
      width: 96%; }
      #menu ul li {
        padding-right: 2%;
        margin-bottom: 3%; }
        #menu ul li a {
          font-size: 1.5em; }

  #innerWrapper {
    width: 100%;
    height: auto;
    top: 13%;
    padding-bottom: 15%; }

  #copyright {
    display: none; }

  #homePhoto {
    height: 60vh;
    width: 100%;
    margin: 1px 1px 1px 1px; }
    #homePhoto.ng-enter {
      -webkit-transform: translate(0px);
      -moz-transform: translate(0px);
      -o-transform: translate(0px);
      transform: translate(0px); }

  #homeAbout.ng-enter, #homePortfolio.ng-enter, #homeCv.ng-enter, #homeContact.ng-enter {
    -webkit-transform: translate(0px);
    -moz-transform: translate(0px);
    -o-transform: translate(0px);
    transform: translate(0px); }

  .homeLinks {
    position: relative;
    width: 100%;
    height: 20vh;
    margin: 2% 1px 1px 1px; }
    .homeLinks h2 {
      position: absolute;
      font-size: 1.5em;
      bottom: -3%;
      right: 5%;
      color: black; }

  #aboutPhoto {
    float: left;
    width: 100%;
    height: 60vh;
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
    position: relative; }
    #aboutPhoto h2 {
      font-size: 1.5em;
      bottom: -2%;
      right: 5%; }
    #aboutPhoto.ng-enter {
      -webkit-transform: translate(0px);
      -moz-transform: translate(0px);
      -o-transform: translate(0px);
      transform: translate(0px); }

  #aboutContent {
    width: 100%;
    height: auto;
    margin: 2% 0px 0px 0px; }
    #aboutContent #aboutDiv h3 {
      width: 90%;
      margin: 8% auto 0% auto;
      font-size: 1.5em; }
    #aboutContent #aboutDiv p {
      width: 90%;
      margin: 4% auto;
      font-size: 1.25em; }
      #aboutContent #aboutDiv p span {
        margin-left: 20px; }
    #aboutContent #aboutDiv img {
      width: 45%;
      height: auto;
      float: right;
      margin-right: 7%;
      margin-bottom: 8%; }
    #aboutContent.ng-enter {
      -webkit-transform: translate(0px);
      -moz-transform: translate(0px);
      -o-transform: translate(0px);
      transform: translate(0px); }

  .projects {
    width: 100%;
    height: 30vh;
    margin: 1px 1px 1% 1px; }
    .projects h2 {
      bottom: 0%;
      right: 1.5%;
      font-size: 1.25em; }

  #cvPhoto {
    width: 100%;
    height: 60vh; }
    #cvPhoto h2 {
      bottom: -2%;
      right: 5%;
      font-size: 1.5em; }
    #cvPhoto.ng-enter {
      -webkit-transform: translateX(0px);
      -moz-transform: translateX(0px);
      -o-transform: translateX(0px);
      transform: translateX(0px); }

  #cvContent {
    width: 100%;
    height: auto;
    margin: 2% 0px 0px 0px; }
    #cvContent.ng-enter {
      -webkit-transform: translateX(0px);
      -moz-transform: translateX(0px);
      -o-transform: translateX(0px);
      transform: translateX(0px); }
    #cvContent #outerDivCV {
      width: 100%;
      height: auto;
      margin: auto;
      top: 50%;
      transform: translateY(-50%);
      font-size: 1.25em; }
      #cvContent #outerDivCV .innerDivCV {
        float: left;
        width: 100%;
        height: auto;
        margin: 0 auto; }
        #cvContent #outerDivCV .innerDivCV h2 {
          font-size: 1.5em;
          text-decoration: underline; }
        #cvContent #outerDivCV .innerDivCV table {
          width: 95%;
          margin: 0 auto; }
          #cvContent #outerDivCV .innerDivCV table .leftColumn {
            text-align: left; }
          #cvContent #outerDivCV .innerDivCV table .rightColumn {
            text-align: right; }
          #cvContent #outerDivCV .innerDivCV table span {
            color: black;
            font-weight: bolder; }
      #cvContent #outerDivCV .innerDivCValt {
        float: left;
        width: 100%;
        height: auto;
        text-align: center;
        position: relative; }
        #cvContent #outerDivCV .innerDivCValt h2 {
          font-size: 1.5em;
          text-decoration: underline; }
        #cvContent #outerDivCV .innerDivCValt table {
          width: 75%;
          margin: -4% auto; }
          #cvContent #outerDivCV .innerDivCValt table ul {
            list-style-type: none;
            text-align: left; }
        #cvContent #outerDivCV .innerDivCValt a {
          margin: 4% auto;
          display: block;
          width: 20%; }
          #cvContent #outerDivCV .innerDivCValt a img {
            width: 40px;
            height: auto; }

  #contactPhoto {
    width: 100%;
    height: 60vh; }
    #contactPhoto h2 {
      bottom: -2%;
      right: 5%;
      font-size: 1.5em; }
    #contactPhoto.ng-enter {
      -webkit-transform: translateX(0px);
      -moz-transform: translateX(0px);
      -o-transform: translateX(0px);
      transform: translateX(0px); }

  #contactContent {
    width: 100%;
    height: 20vh;
    margin: 2% 0px 0px 0px; }
    #contactContent.ng-enter {
      -webkit-transform: translateX(0px);
      -moz-transform: translateX(0px);
      -o-transform: translateX(0px);
      transform: translateX(0px); }
    #contactContent div {
      height: 60px;
      width: 60%; }
      #contactContent div .socialMediaLinks {
        display: block;
        height: 45px;
        width: 25%;
        position: relative;
        float: left;
        background-position: center;
        background-repeat: no-repeat;
        background-size: auto 100%;
        -webkit-filter: brightness(75%);
        /* Chrome, Safari, Opera */
        filter: brightness(75%); } }
@media screen and (max-width: 700px) {
  body {
    font-size: 18px;
    height: auto; }

  #header {
    height: 23%; }
    #header h3 span {
      display: none; }

  #outerWrapper {
    width: 100%;
    height: auto;
    float: left; }

  #innerWrapper {
    top: 20%;
    padding-bottom: 8%; }

  #menu {
    height: 23%; }
    #menu ul li a {
      font-size: 1em; }

  #aboutContent #aboutDiv img {
    width: 80%; } }
@media screen and (max-width: 650px) {
  body {
    font-size: 18px;
    height: auto; }

  #header {
    height: 12%; }
    #header h3 span {
      display: none; }

  #outerWrapper {
    width: 100%;
    height: auto;
    float: left; }

  #innerWrapper {
    top: 10%;
    padding-bottom: 8%; }

  #menu {
    height: 11%; }
    #menu ul li a {
      font-size: 1em; }

  #aboutContent #aboutDiv img {
    width: 80%; } }

/*# sourceMappingURL=portfolio.cs.map */
