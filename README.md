# CI-Kata-Madness
```
As a software Artisan,

I want to be able to build the "muscle memory" needed to stand up a basic CI pipeline

So that I can run end-to-end tests whenever I am ready to commit working code.
```

### A Note on Toolchains and Tech stacks
While this kata was developed using a GitHub/Travis-CI/Docker/Selenium tech stack, there is no one right way to play any of these cards. The ultimate goal is to incrementally grow the pipeline until all cards are complete.

# Template Code
A skeleton application with a front end and a back end has been provided. Feel free to fork this repo or download a zipfile of the code in order to create a wholly-new repo. The goal is to allow you to focus on the CI portion rather than developing an MVP application.

### .NET Core Front End

The front end is a React single page app. In order to use webpack to bundle the javascript, it is nested in a DotNetCore solution.

To install the dependencies, navigate to the CIKataFrontEnd.React directory and run `npm install` followed by `npm run wbp` in order to create the webpack bundle. If you make any changes to the HTML or Javascript code, you will need to run `npm run wbp` again. 

To run unit tests, in the same directory run `npm test`. The test should pass. When you run this locally, the button will not work until you are able to call the running back end project. 

**Note**: the current URL being fetched in `App.js:10` is a placeholder and will need to be updated to actually reach the back end project.

### .NET Core Back End
A bare bones web api project has been provided with a single end point that returns hardcoded data. There is a single test that should pass included in this solution.

# Card Backlog

## Front End Pipeline
```
As a software Artisan,

I want the solution to build and unit tests to run everytime I push the front end code to the repo

So that I can see if there are any errors.
```
Acceptance Criteria: Pushing code to the repo triggers a build and, upon build success, runs unit tests.

## Back End Pipeline
```
As a software Artisan,

I want the solution to build and unit tests to run everytime I push back end code to the repo,

So that I can see if there are any errors.
```
Acceptance Criteria: Pushing code to the repo triggers a build and, upon build success, runs unit tests.

## Containerize Front End Application
```
As a software Artisan,

I want my front end application to be packaged in a container, 

So that I can run it without an IDE in any environment.
```
Acceptance Criteria: Run container and reach the application home page from the browser

## Containerize Back End Application
```
As a software Artisan,

I want my back end application to be packaged in a container, 

So that I can run it without an IDE in any environment.
```
Acceptance Criteria: Run container and receive expected values in the browser

## Write End-to-End Tests
```
As a software Artisan,

I want to have end-to-end tests written,

So that I can confirm my front end and back end are communicating correctly.
```
Acceptance Criteria: With both containers running, end-to-end tests should pass by pushing a button and receiving expected result. Tests fail if containers are not running.

## Image Refresh
```
As a software Artisan,

I want to have a new image created whenever the code changes,

So that the container always reflects the current version of the source code.
```
Acceptance Criteria: When code is pushed, an updated image is created.

## End-to-End Testing in Pipeline
```
As a software Artisan,

I want to have my CI pipeline run end-to-end tests as part of the build process,

So that I know my application will run.
```
Acceptance Criteria: End-to-end tests run as part of the build process.

## End-to-End Testing Only on Pull Request Build
```
As a software Artisan,

I want to have my build behave differently for push requests and pull requests,

So that I am not spending server resources at inappropriate times.
```
Acceptance Criteria: End-to-End tests do not run when pushing code, only when a pull request is created.

## Build Process Runs When Amending Pull Request
```
As a software Artisan,

I want my build process to be triggered when making changes to the code included in a pull request,

So that I know the updated code is being checked.
```
Acceptance Criteria: New or updated code pushed to an existing pull request triggers a build and, upon build success, runs all tests.
