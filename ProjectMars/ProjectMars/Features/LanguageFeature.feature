Feature: LanguageFeature

As a language page 
I would like to create, edit and delete languages 
So that I can manage users' language and level successfully



Scenario Outline: Create language and level record with valid details
	   Given User is logged into localhost URL successful
	   When Add new '<Language>' and '<Level>' to the language list
	   Then New record with '<Language>' and '<Level>' are added successfully

Examples: 
| Language | Level          |
| English  | Fluent         |
| Korean   | Conversational |
| Spanish  | Basic          |
| Hindi    | Fluent         |

Scenario Outline: Update an existing language record with valid details
	Given User is logged into localhost URL successful
	When I update language '<Language>' and level '<Level>' of an existing record
	Then A language '<Language>' updated successfully message should be displayed
	 

Examples: 
| Language | Level  |
| French   | Fluent |

Scenario Outline: Delete an existing language record with valid details
    Given User is logged into localhost URL successful
	When I deleted language '<Language>' of an existing record
	Then A language '<Language>' deleted successfully message should be displayed

Examples: 
| Language | Level |
| Spanish  | Basic |

Scenario: Check the cancel function of the records
	Given User is logged into localhost URL successful
	When Check cancel button of the records
	Then Cancel function is working successfully 

Scenario Outline: For negative testing add skills record with valid details 
Given User is logged into localhost URL successful
When Add new record '<Language>' and '<Level>' to the language list
Then Record with '<Language>' and '<Level>' are added successfully

Examples: 
| Language | Level  |
| English  | Fluent |
