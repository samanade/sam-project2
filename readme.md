# SAMUEL PRACTICAL PROJECT 
> Simple random number & letter generator app made using visual studio, C# and ASP.NET and deployed using GitHub actions and Terraform.

## Contents
* [Brief](#brief)
   * [Additional Requirements](#additional-requirements)
   * [My Approach](#my-approach)
* [Architecture](#architecture)
   * [CI Pipeline](#ci-pipeline)
* [Project Tracking](#project-tracking)
* [Risk Assessment](#risk-assessment)
* [Testing](#testing)
* [Known Issues](#known-issues)
* [Future Improvements](#future-improvements)
* [Authors](#authors)

## Brief
The brief provided to us for this project sets the following out as its overall objective:
"Creating an application that generates “Objects” upon a set of predefined rules."

I have decided to create a PT management app that allows users to create, read, update andd delete clients and workouts to demonstrate knowledge learnt. 

### Project Requirements

* A Trello board
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

## Architecture 

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
 
* Create a workout (satisfies 'Create') and assign them to a client:
   * *Title* 
   * *Date* 
   * *Thumbnail* 
   * *Client* the workout will be assigned too
  
* View and update client and workout details (satisfies 'Read' and 'Update')
* Delete client or workout (satisfies 'Delete')

## Architecture
### Database Structure
Pictured below is an entity relationship diagram (ERD) showing the structure of the database.
![architecture][architecture]
Everything in green has been implemented into the app, while everything in red has not. The ERD models a many-to-many relationship between Client entities and Workout entities using an association table. This allows the user to create clients and asign multiple workouts in the database with one client. Similarly, many workouts can therefore be associated with a client.

## Project Tracking
Trello was used to track the progress of the project (pictured below). You can find the link to this board here: https://trello.com/b/aJCcDQ1b/

![trello][trello]

## Risk Assessment
![RiskAssessment][riskassessment]

## Front-End Design
When the user navigates to the URL, they are directed to the home page:
![homeloggedout][homeloggedout]

Selecting "Clients" tab on the nav menu will bring up the follow page showing a list of all current clients:

![clientslanding][clientslanding]

Clicking the "Create New" link directs the user to a create form where they can enter a new client : 

![newclient][newclient] 

The same structure is followed for the "Workouts tab" from the homepage. The user is first directed to a page showing a list of all workouts that can edited or deleted. A new workout can also be created by following the "Create Workout" link. 

Workouts for a client can be viewed from clients page by selecting "View Workouts" next to their name : 

![viewworkouts][viewworkouts]

## Known Issues
There are a few bugs with the current build of the app:
* The validation script does not render so HTML form inputs are not validated according to data type
* Workouts can be edited however when editing a client details a not null reference error occurs
## Future Improvements
There are a number of improvements I would like to implement (outside of current bugs):
* Allow exercises to also be added to workouts 
* Login feature with account page where user can personalize their profile 

## Authors
Samuel Nwangwu



[architecture]: https://imgur.com/vBsTqu6
[trello]: https://i.imgur.com/X68OFUm.png
[riskassessment]: https://i.imgur.com/rXQhjK7.png
[homeloggedout]: https://i.imgur.com/6p934TM.png
[clientslanding]: https://i.imgur.com/SdDG4Wb.pngs
[newclient]: https://i.imgur.com/PqrkyfJ.png
[viewworkouts]: https://i.imgur.com/PbUlcb6.png

