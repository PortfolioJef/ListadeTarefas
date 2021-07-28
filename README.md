# UbiStart
Lista de tarefas

Goals:
The goal for this challenge is to develop a Data Driven Web API using ASP.Net Core 3.1 and
Entity Framework Core. The Web API must be compliant with the RESTful architecture and transition
data in json format. We expect to be developed only the Web API and no user interface.

● An TODO item should NOT be inserted in the database without a description;

● An TODO item should be inserted;

● An TODO item should be deleted;
● An TODO item should be edited;
● All TODO items should be listed;
● An finished TODO item should not be updated;
User Requirement Acceptance Criteria
As a Client I want to create an account so that I can
manage my TODO items
● Given that I'm creating an account, I want to
inform my e-mail and password
As a Client I want to log in so that I can authenticate
and use de the App
As a Client I want to insert a TODO item so that I can
add a TODO to my list of tasks
● The App should store the Date and Time of the
insertion
● Inform a Description and a Due Date
As a Client I want to conclude (finish) a TODO item so
that I can set the work done
● The platform should store the Date and Time the
TODO item was finished
As a Client I want to edit the TODO item so that I can
update my list
● I can update the description and due date
● The platform should store the Date and Time the
TODO item was updated
● The user CANNOT edit a finished TODO item
As a Client I want to list all of my TODO items so that I
can work on them
● I want to list ONLY my TODO items
● If the TODO item is delayed, the platform should
return if item is delayed
As an Administrator I want to log in so that I can
authenticate and use de the App
● The platform should provide a default User
As an Administrator I want to list all TODO items so that
I can view all the inserted tasks
● The list should be paginated
● The list should contain the user e-mail,
description and due date
As an Administrator I want to filter the list of TODO
items by dalayed
● The list should be paginated
● The list should contain the user e-mail,
description and due dateEvaluation criteria:
● Project structure. The correct use and appropriate project layers;
● Correct configuration of Swagger;
● Authentication and Authorization via JWT;
● Use of the EntityFrameworkCore;
● Correct use of environment variables;
Optional
● Unit tests
● Integration tests

