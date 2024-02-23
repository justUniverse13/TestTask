Feature:  Campaign Creation

Background: Login to Campaign Creation and validate page name
  Given User is login in using 'Testuser' account

@Functional @Integration
Scenario: User login and logout
  When User clicks on the logout link
  Then User see the Campaign Creation page  