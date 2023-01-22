Feature: NegativeScenarios

To check if the profile page accepts invalid data

@tag1

Scenario Outline: Add Language with invalid details
	Given I logged into Mars application successfully
	When I entered  '<language>' and '<level>' with invalid data
	Then  Error '<message>'  should be displayed 
	Examples: 

	| language | level  | message                                               |
	| English  | Basic  | English is added to your languages                    |
	| English  | Fluent | This language is already exist in your language list. |
	| English  | Basic  | Duplicated data                                       |
	| French   |        | Please enter language and level                       |
	
Scenario: 'Add New' button not displayed after adding 4 languages.
	Given I logged into Mars application successfully
	When I add four languages to my profile and try to add fifth language.
	Then 'Add New' button should not be displayed for languages on profile page



	
Scenario Outline: Add skill :negative scenarios
	Given I logged into Mars application successfully
	And I have already added a skill record
	When I added '<skill>' and '<level>' in add skill textbox
	Then  Error '<message>'  should be displayed 
	Examples: 

	| skill | level  | message                                             |
	| Crochet	|Beginner| This skill is already exist in your skill list. |
	| Crochet   | Basic	| Duplicated data								   |
	| Dance     | 	    | Please enter skill and experience level		   |




	Scenario Outline:Add Education on profile page with invalid data 
	Given I logged into Mars application successfully
	When I add invalid data for  '<College>', '<Country>','<Title>','<Degree>','<Year of Graduation>'
	Then Error '<message>' should be displayed
	Examples:
	| College | Country     | Title  | Degree     | Year of Graduation | message                    |
	| AUT     | New Zealand | B.Tech | Graduation | 2020               | "Education has been added" |
	| AUT     | New Zealand | B.Tech | Graduation | 2020               | The information is already exist |
	| AUT     | New Zealand | B.Tech |		      | 2020               | Please enter all the fields |



Scenario Outline: Add Certifications on profile page, with invalid data.
	Given I logged into Mars application successfully
	And I have already added a Certification record
	When I add invalid data in  '<Certificate>', '<Certificate from>', '<Year>'
	Then I should see the error '<message>' 
	Examples:
	| Certificate					| Certificate from   |  Year  | message                    |
	| Salesforce Administrator		| Salesforce		 |  2020  | The information is already exist|
	| Salesforce Administrator		|					 |  2020  | Please enter Certification Name, Certification From and Certification Year|
