Feature: Checking the functionality of flight booking at Expedia

Scenario: Open browser and website


Scenario: Multicity Round trip
Given Open the GoogleChrome  
Then Open the Expedia Website
Then select flight tab
And select MultiCity Option
Then enter Source1 and Destination1
And Choose DateOfJourney1 and Choose Number of travelers
Then now choose Source2 and Destination2
And Choose DateOfJourney2 
Then now choose Source3 and Destination3
And Choose DateOfJourney3
Then Click On the Search Button


#Scenario: Trip Summary
When Ensuring correct information of all three flights
Then Ensuring the correct amount per person

 #Scenario: Closing the Browser
   #  When Report are generate
     Then  now Close browser
      

