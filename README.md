# Zinger
 ## [Table of Contents](#table-of-contents)
 1) [Introduction](#Introduction)
 2) [Purpose](#Purpose)
 3) [Database ERD](#Database-ERD)
 4) [Draft WireFrames](#Draft-WireFrames)
 5) [Login Page](#Login-Page)
 6) [Home](#Home)
 7) [Profile Page](#Profile-Page)
 8) [Messages](#Messages)
 9) [Settings](#Settings)
 10) [User Stories](#User-Stories)
 11) [Use Cases](#Use-Cases)
 12) [Zinger Use Case Diagram](#Zinger-Use-Case-Diagram)
 13) [Requirements List](#Requirements)
 14) [Test Table](#Test-Table)
 15) [Prototype WIP](#Prototype)

# <a name="Introduction"></a>
#### <div align="Left"> Introduction</div>  [Return to Table of Contents](#table-of-contents)

Due to COVID-19, many people have had to change their routines and life habits. This includes social engagement. Online engagement through social media is becoming more of a modern public square to communicate and share ideas with one another. Furthermore, in recent years, the demand for secure messaging applications has spiked dramatically as awareness of hacking capability has increased. Coming from somewhat of a security background myself, I am interested to learn how to integrate end-to-end encryption in this application.

# <a name="Purpose"></a>
#### <div align="Left"> Purpose</div>  [Return to Table of Contents](#table-of-contents)

Create a social media application with private messaging capabilities in which users can create posts for their pages and engage with others in the new modern public square. The final product will have MFA and E2EE. Share your thoughts, links, videos, and images with your followers and be able to have conversations. _(This is basically a Twitter clone project)_.
***

# <a name="Database-ERD"></a>
#### <div align="Left"> Database ERD</div>  [Return to Table of Contents](#table-of-contents)
![Database ERD](https://github.com/mcforma/Zinger/blob/main/Database/Project%20Step%204%20-%20Zinger%20ERD.png)
---

# <a name="Draft-WireFrames"></a>
#### <div align="Left"> Draft WireFrams</div>  [Return to Table of Contents](#table-of-contents)
---

# <a name="Login-Page"></a>
##### <div align="Left"> Login Page</div>  [Return to Table of Contents](#table-of-contents)
![Login page](https://github.com/mcforma/Zinger/blob/main/Wireframe/Login.png)
---

# <a name="Home"></a>
##### <div align="Left"> Home</div>  [Return to Table of Contents](#table-of-contents)
![Home](https://github.com/mcforma/Zinger/blob/main/Wireframe/Home.png)
---


# <a name="Profile-Page"></a>
##### <div align="Left"> Profile Page</div>  [Return to Table of Contents](#table-of-contents)
![Profile Page](https://github.com/mcforma/Zinger/blob/main/Wireframe/Profile.png)
---

# <a name="Messages"></a>
##### <div align="Left"> Messages</div>  [Return to Table of Contents](#table-of-contents)
![Messages](https://github.com/mcforma/Zinger/blob/main/Wireframe/Messages.png)
---

# <a name="Settings"></a>
##### <div align="Left"> Settings</div>  [Return to Table of Contents](#table-of-contents)
![Settings](https://github.com/mcforma/Zinger/blob/main/Wireframe/Settings.png)

# <a name="User-Stories"></a>
#### <div align="Left"> User Stories</div> [Return to Table of Contents](#table-of-contents)
#### [User Stories](https://github.com/mcforma/Zinger/blob/main/Requirements/User%20Stories):  

1. As a social person, I want a way to connect with my friends and family and meet new people so that we can interact 
socially when we can’t be together face-to-face (as with COVID-19).

2. As an employee of my company’s marketing division I need to ensure we have a wide social media presence so that we can 
garner a lot of views for advertisement.

3. As a person who moved to another state to take a job, I want a way to see my friends and family’s posts and activity in 
my feed so that I can stay up to date with them.

4. As an active member in my extended family,I want a secure way to privately message my family so that our data is protected 
and remains under our own control.

# <a name="Use-Cases"></a>
#### <div align="Left"> Use Cases</div> [Return to Table of Contents](#table-of-contents)
#### [Use Cases](https://github.com/mcforma/Zinger/blob/main/Requirements/Use%20Cases): 

1. Given a new user, allow the user to register for a new account by providing basic information including full name, date of birth, a unique user handle, 
a display name.

2. Given a new user, allow user to create a password once they have provided account details during registration.

3. Given a new user, upon account submission of account registration form and creation of a strong password, generate unique user ID and send registration 
verification email to user’s provided email address.

4. Given the current user, when the user is on their home feed, populate (at least some) of the content posted by the other users that they follow.

5. Given the current user, make recommendations of who to follow in their home feed.

6. Given the current user, allow user to search for other users or by hashtags in the search bar.

7. Given the current user, allow them to reset their password and deactivate or delete their account in the settings page.

8. Given the current user, allow user to send secure message from one user to another.

9. Given an input from a user into the “new zing” text box, allow user to click “Zing” button and post the Zing to the user’s timeline and propagate out to 
followers’ feeds. NULL entries not allowed.

10. Given a current user, allow user to see amount of views for their zings.


# <a name="Zinger-Use-Case-Diagram"></a>
#### <div align="Left"> Zinger Use Case Diagram</div> [Return to Table of Contents](#table-of-contents)  ![Zinger Use Case Diagram](https://github.com/mcforma/Zinger/blob/main/Requirements/Zinger%20Use%20Case%20Diagram.png)


# <a name="Requirements"></a>
#### <div align="Left"> Requirements</div>  [Return to Table of Contents](#table-of-contents)
#### [Initial Requirements doc](https://github.com/mcforma/Zinger/blob/main/Requirements/Requirements%20List)

| Requirement ID | Requirement                                                                                         | Test Method   | Test ID |
|----------------|-----------------------------------------------------------------------------------------------------|---------------|---------|
| 1.0.0.0        | The system shall have UI display with option to click “log in” or “register”.                       | Inspect       | 1       |     
|   1.1.0.0      | If user is a new user, they shall select “register”, else select “log in”.                          | Inspect       | 1       |
|     1.1.1.0    | The system shall have access to read from and write to database.                                    | Test          | 1       |
|     1.1.2.0    | If the user selects “log in”, then the system shall prompt the user for their username and password and log the user in upon a valid check against the                            authentication service.                                                                             | Test          | 3       |
|     1.1.3.0    | If the user selects “register”, they will be asked to provide basic information such as full name, date of birth, email address, display name, as well as                        creating a unique user handle, and a password that meets strong password requirements.              | Test          | 1       |                            
|       1.1.3.1  | The system will check if the requested user handle is unique. If true, user may continue, if false, reject user handle as unavailable. | Test          | 1   |
|       1.1.3.2  | The system will require that user must agree to the terms of service before submitting account registration request.  | Test          | 1       |             
|       1.1.3.3. | The system will generate a unique user ID and send an email to the email address supplied by the user to verify their email address. | Test        | 1       | 
|       1.1.3.4. | Upon system verification of email, the user will be able to log in as an existing user.             | Test          | 2       |
|     1.1.4.0    | Upon a valid check of existing users supplied credentials against authentication server, system will log user in.  | Test          | 3       |               
|   1.2.0.0      | The system shall have a home feed page.                                                             | Inspect       | 3       |
|     1.2.1.0    | The user shall be able to post “zings” which may contain text, images, emojis, video, or audio.     | Test          | 4       |
|     1.2.2.0    | The home feed page shall be fed zings from users said user follows, as well as recommendations of people/accounts to follow.  | Test          | 5       |    
|   1.3.0.0      | The system shall allow user to search for other users and by hashtags in search bar.                | Test          | 6       |
|   1.4.0.0      | The system shall allow user to reset password, deactivate or delete account, or download account data. | Test          | 7       |
|   1.5.0.0      | The system shall allow user to see how many views their zings receive.                              | Inspect       | 9       |
|   1.6.0.0      | The system shall have a private messaging system.                                                   | Test          | 10      |
|     1.6.1.0    | The private messaging system shall allow one user to message another directly.                      | Inspect       | 10      |
|     1.6.2.0    | The private messaging system shall have end-to-end encryption.                                      | Inspect       | 11      |
| 2.0.0.0        | The system shall save the data provided by users in the Zinger database.                            | Test          | 1       |
|   2.1.0.0      | The system shall provide a simple GUI similar to Twitter’s.                                         | Inspect       | 12      |
|   2.2.0.0      | There will be a menu bar on the left side of the screen available on every page.                    | Inspect       | 12      |
|   2.3.0.0      | The system shall accept user input via typing, text, or image, video, audio files.                  | Test          | 4       |
| 3.0.0.0        | The system shall be developed using C#, T-SQL, and ASP.NET.                                         | Inspect       |         |
|   3.1.0.0      | The system shall be hosted in GitHub and Azure.                                                     | Inspect       |         |


# <a name="Test-Table"></a>
#### <div align="Left"> Test Table</div>  [Return to Table of Contents](#table-of-contents)

| Test ID | Requirement ID | Test Procedure                                                                                                                                                                      | Status     | Time Stamp |
|---------|----------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|------------|
| 1       | 1.0.0.0        | Create a new user account and check database for new account.                                                                                                                  | Not Tested |  |
| 2       | 1.1.2.4        | Successfully send email during email verification process                                                                                                                      | Not Tested |  |
| 3       | 1.2.0.0        | Log in with created account,  User should arrive at user home page.                                                                                                            | Not Tested |  |
| 4       | 1.2.1.0        | User creates a Zing which populates into their feed.                                                                                                                          | Not Tested |  |
| 5       | 1.2.1.2        | Users Zings should populate into followers' feeds.                                                                                                                            | Not Tested |  |
| 6       | 1.3.0.0        | Users should be able to search for other users by hastags in search bars on present on all application's web pages                                                  | Not Tested |  |
| 7       | 1.4.0.0        | Reset account password, deactivate, delete account, download account data from settings page                                                                                  | Not Tested |  |
| 8       | 1.4.0.0        | Reset password from log in screen by requesting an email with a reset link be sent to your account after verifying email on file.                                           | Not Tested |  |
| 9       | 1.5.0.0        | Check how many views a particular Zing received.                                                                                                                              | Not Tested |  |
| 10      | 1.6.1.0        | Directly message one user from another and receive reply message to verify working messaging system.                                                                          | Not Tested |  |
| 11      | 1.6.2.0        | Check database to make sure messages are hashed from end-to-end encryption.                                                                                                    | Not Tested |  |
| 12      | 2.2.0.0        | Ensure layout is appropriately modeled as per requirements (menu, GUI, et.).                                                                                                  | Not Tested |  |

# <a name="Prototype"></a>
## <div align="Left">Prototype WIP</div> [Return to Table of Contents](#table-of-contents)
## [Prototype (Adobe XD interactive)](https://xd.adobe.com/view/5f8f3c16-5ad5-4932-a015-a8dfd0dba23a-0adc/?fullscreen)

## [Prototype PNGs](https://github.com/mcforma/Zinger/tree/main/Prototype)
Here is the link to PNGs of the prototype, with descriptions of each page. At the bottom of the Prototype README, there is also a link to the Adobe XD interactive prototype that is linked above.
