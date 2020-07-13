Feature: Search for hotels and see available rooms after selecting a hotel
	Search for hotels based on user specified criteria
	Filter hotel search results based on Star Rating
	Select a hotel from search results and see available rooms

Background:
		Given I launch a 'Chrome' Browser
		And open a website using url 'http://www.vacationsdirect.com'

@acceptanceTest
Scenario: Search for hotels in New York City for dates a month in the future
	Given I have navigated to the application
	And I click on Hotel button 
	And I enter city: '<city>', future check in date: '<checkInDay>', check out date: '<checkOutDay>' and click on search for hotels button	
	Then Hotel Search Results are displayed	
	Examples: 
	| city          | checkInDay | checkOutDay | 
	| New York City | 0          | 29          | 

	# One day in future from current day starts at 0. Please provide values for checkInDay and checkOutDay accordinlgy

@acceptanceTest
Scenario: Filter hotel search results based on 'Star Rating'
	Given I have navigated to the application
	And I click on Hotel button 
	And I enter city: '<city>', future check in date: '<checkInDay>', check out date: '<checkOutDay>' and click on search for hotels button	
	Then Hotel Search Results are displayed	
	Then I Filter Hotel Search Results based on Star Rating: '<starRating>'
	Examples: 
	| city          | checkInDay | checkOutDay | starRating |
	| New York City | 0          | 29          | 5	        |

	# One day in future from current day starts at 0. Please provide values for checkInDay and checkOutDay accordinlgy

@acceptanceTest
Scenario: See available rooms after selecting a hotel from the hotel search results
	Given I have navigated to the application
	And I click on Hotel button 
	And I enter city: '<city>', future check in date: '<checkInDay>', check out date: '<checkOutDay>' and click on search for hotels button	
	Then Hotel Search Results are displayed	
	Then I Filter Hotel Search Results based on Star Rating: '<starRating>'
	Then I selected a hotel from the Search Results
	Then I see available rooms

	Examples: 
	| city          | checkInDay | checkOutDay | starRating |
	| New York City | 0          | 29          | 5	        |

	# One day in future from current day starts at 0. Please provide values for checkInDay and checkOutDay accordinlgy

