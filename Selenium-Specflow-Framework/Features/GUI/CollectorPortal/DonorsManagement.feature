Feature: DonorsManagement

Background: Login to Donors Management page and validate page name
  Given User is login in using 'Testuser' account

@Functional @Integration
Scenario: User login and logout
  When User clicks on the logout link
  Then User see the Donors Management page  
