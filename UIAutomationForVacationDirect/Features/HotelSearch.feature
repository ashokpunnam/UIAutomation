﻿Feature: Search for hotels and see available rooms after selecting a hotel
	Search for hotels based on user specified criteria
	Filter hotel search results based on Star Rating
	Select a hotel from search results and see available rooms

Background:
		Given I launch a 'Chrome' Browser
		And open a website using url 'http://www.vacationsdirect.com'

@acceptanceTest
Scenario: Search for Hotels in a city for dates provided by user and filer the search by star rating and see available rooms
	Given I have navigated to the application
	And I click on Hotel button 
	And I enter city, future check in date, check out date and click on search for hotels button
	| city          | checkInDay | checkOutDay |
	| New York City | 0          | 29          |	
	Then Hotel Search Results are displayed
	Then I Filter Hotel Search Results based on Star Rating 
	| starRating |
	| 5          |
	| 4          |
	Then I selected a hotel from the Search Results
	Then I see available rooms

