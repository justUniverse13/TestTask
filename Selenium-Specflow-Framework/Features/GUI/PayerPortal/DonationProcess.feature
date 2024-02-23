Feature: DonationProcess

Donation Process - allows payers to contribute to campaigns.

Background: Login to Donation Process page and validate page name
  Given User is login in using 'Testuser' account

@Functional @Integration
Scenario: User login and logout
  When User clicks on the logout link
  Then User see the login page 
