Feature: Skills

As a Seller in Mars Application
I want to Add, Update and Delete Skills (with Valid Data) in my Profile Details 
So that
The people seeking for some skills can look into my details.

@tag1
Scenario Outline:T01- Add Skills on profile page
	Given I logged into Mars application successfully
	When I add '<skill>' and '<level>' 
	Then The skills record '<skill>' and '<level>'  should be added successfully on profile page.
	Examples:
	| skill   | level |
	| Painting | Beginner |
	| Crochet | Expert |
	
Scenario:T02- Update an existing skill on profile page
	Given I logged into Mars application successfully
	When I update skill and skill experience level
	Then Updated skill record should be displayed on profile page 

Scenario:T03- Delete an existing skill on profile page
Given I logged into Mars application successfully
When I delete a skill record 
Then Deleted skill record should NOT be displayed on profile page 
