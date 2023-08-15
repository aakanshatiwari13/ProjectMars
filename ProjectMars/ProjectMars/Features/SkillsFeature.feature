Feature: SkillsFeature

As a Skills page
I would like to create, edit skills and level records
So that I can manage users' skills and level successfully


Scenario Outline: Create skills and level record with valid details
	 Given User is logged into localhost URL successful
	   When Add new '<Skills>' and '<Level>' to the skills list
	   Then New record with '<Skills>' and '<Level>' are added successfully

Examples: 
| Skills | Level        |
| C++    | Expert       |
| Java   | Intermediate |
| C#     | Beginner     |

Scenario Outline: Update an existing skills record with valid details
	Given User is logged into localhost URL successful
	When I update skills '<Skills>' and level '<Level>' of an existing record
	Then A skills '<Skills>' updated successfully message should be displayed
	 

Examples: 
| Skills | Level    |
| SQL    | Beginner |

Scenario Outline: Delete an existing skills record with valid details
    Given User is logged into localhost URL successful
	When I deleted skill '<Skills>' of an existing record
	Then A skill '<Skills>' deleted successfully message should be displayed

Examples: 
| Skills | Level    |
| SQL    | Beginner |

Scenario Outline: For negative testing add skills record with valid details 
    Given User is logged into localhost URL successful
	When Add new record '<Skills>' and '<Level>' to the skills list
	Then Record with '<Skills>' and '<Level>' are added successfully

Examples: 
| Skills | Level        |
| !@#$   | Expert       |
| Java   | Intermediate |
|        | Intermediate |

Scenario: Check the cancel function of the records
	Given User is logged into localhost URL successful
	When Check cancel button of the records
	Then Cancel function is working successfully 