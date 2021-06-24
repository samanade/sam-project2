# SAMUEL PRACTICAL PROJECT 
> Simple random number & letter generator app made using visual studio, C# and ASP.NET and deployed using GitHub actions and Terraform.

## Contents
* [Brief](#brief)
   * [Project Requirements](#project-requirements)
   * [My Approach](#my-approach)
	*[Terraform](#terraform)
* [Project Tracking](#project-tracking)
* [Architecture](#architecture)
   * [CI Pipeline](#ci-pipeline)
* [Risk Assessment](#risk-assessment)
* [Testing](#testing)
* [Known Issues](#known-issues)
* [Authors](#authors)

## Brief
The brief provided to us for this project sets the following out as its overall objective:
"Creating an application that generates “Objects” upon a set of predefined rules."

I have decided to create a PT management app that allows users to create, read, update andd delete clients and workouts to demonstrate knowledge learnt. 

### Project Requirements

* A Kanban board (Asana)
* Clear documentation architecture and risk assessment
* A c#-based functional application that follows best practices and design principles
* Test suites for the application, which will include automated tests for validation of the application
* To produce an application with fully integrated using the Feature-Branch model into a Version Control System which will subsequently be built through a CI server and deployed to a cloud-based environment.
* To ensure if a change is made to the project Azure Pipelines recreates and redeploys the changed application
* The project must follow a setvice orientated architecture
* The application must be deployed using Azure as a platform via Terraform

## Technologies
* C# - version 9.0
* ASP.NET- version 5.0.5
* Terraform - version 1.0.0
* GitHub Action

## Project Tracking
Asana was used to track the progress of the project (pictured below). You can find the link to this board here: https://app.asana.com/0/1200497255553431/board
![asana][asana]

## Architecture 
Pictured below is an architecture diagram illustrating how all the processes interact for the project. 
![architecture][architecture]

The project specification requires at least 4 service orientated services to work together.
Where:
* Service 1 is the core service this will enable the rendering of the HTML that is required to interact with the application as well as being responsible for communciating with the other three services. 
* Service 2 and 3 are services required to generate a random object.  
* Finally, service 4 will also generate an object based upon those of service 2 and 3.

### My Approach
Service 1 render HTML and required interact with the application:
      * This is shown as the front end which is able to communicate with the other services to show the result of the services.
Service 2 that will generate a random object:
      * Generates a random number
Service 3 generates another random object:
      * Generates a random letter 
Service 4 generates object based on service 3 and 4:
      * This merges service 2 and 3 to produce a string.

#### Terraform
Terraform was used to deploy infrastructure as code to Azure, creating an app service plan and respective web apps.

Terraform init - to initialise the terraform file (main.tf). 
Terraform plan- this creates an execution plan, which lets you preview the changes that Terraform plans to make to your infrastructure. 
Terraform - Apply this executes the actions proposed in a Terraform plan

Once completed produces four different app services, under the same app service plan in the same resource group as picture below.

![Terraform][terraform]


## Risk Assessment
![RiskAssessment][riskassessment]

## Testing 
This section contains the testing details including the code coverage report and unit testing conducted.
![Testing1][testing1]
![Testing2][testing2]

The testing conducted here was Arrange, Act and Assert testing pattern, a total of 4 unit tests were conducted for this project which tested the operations required for those controllers such as producing the required output.

The tests consisted of x unit testing. These are designed to assert that if a certain function is run, the output should be a known value. 
The controllers were tested this included the merge, numbers, home and letters controller. 
The line coverage is 70.3%. The result could of been higher if I was able to find a way to exclude code that was not intended to be tested, for instance the views in the front end.


## Known Issues
* The workflow doesn't complete due to an error with plan name not being consistent which I was unable to resolve. 
![Error][error]

* I believe the issue arised from the main.yml file attempting to deploy the service to the incorrect app service plan, however I was unable to locate where this call was originating from. 

## Authors
Samuel Nwangwu



[architecture]: https://imgur.com/vBsTqu6.png
[asana]: https://i.imgur.com/X3SnjbC.png
[riskassessment]: https://i.imgur.com/fNKPJB4.png
[testing1]: https://i.imgur.com/894sftn.png
[testing2]: https://i.imgur.com/IYbR1vQ.png
[error]: https://i.imgur.com/nxOuiVh.png
[Terraform]: https://i.imgur.com/muFP8Bj.png

