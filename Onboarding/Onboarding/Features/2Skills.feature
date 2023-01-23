Feature: 2Skills

As a Seller in Mars Application
I want to add, update and delete Skills in my Profile Details 
So that
The people seeking for some skills can look into my details.

@tag1
Scenario Outline: Add Skills on profile page
	Given I logged into Mars application successfully
	When I add '<skill>' and '<level>' 
	Then Added record should be displayed in skill list under skill tab on profile page
	Examples:
	| skill   | level |
	| Crochet | Expert |
	
Scenario:Update an existing skill on profile page
	Given I logged into Mars application successfully
	When I update skill and skill experience level
	Then Updated skill record should be displayed on profile page 

Scenario:Delete an existing skill on profile page
Given I logged into Mars application successfully
When I delete a skill record 
Then Deleted skill record should NOT be displayed on profile page 
