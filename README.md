# Zinger
 ## [Table of Contents](####table-of-contents)
 1) [Introduction](#Introduction)
 2) [Purpose](#Purpose)
 3) [Database ERD](#Database ERD)
 4) [Draft WireFrames](#Draft WireFrames)
 5) [Login Page](#Login Page)
 6) [Home](#Home)
 7) [Profile Page](Profile Page)
 8) [Messages](#Messages)
 9) [Settings](#Settings)
 10) [User Stories](#User Stories)
 11) [Use Cases](#Use Cases)
 12) [Zinger Use Case Diagram](#Zinger Use Case Diagram)
 13) [Requirements List](#Requirements List)
 14) [Test Table](#Test Table)

# <a name="Introduction"></a>
#### <div align="Left"> Introduction</div>  [Return to Table of Contents](####table-of-contents)

Due to COVID-19, many people have had to change their routines and life habits. This includes social engagement. Online engagement through social media is becoming more of a modern public square to communicate and share ideas with one another. Furthermore, in recent years, the demand for secure messaging applications has spiked dramatically as awareness of hacking capability has increased. Coming from somewhat of a security background myself, I am interested to learn how to integrate end-to-end encryption in this application.

#### Purpose:

Create a social media application with private messaging capabilities in which users can create posts for their pages and engage with others in the new modern public square. The final product will have MFA and E2EE. Share your thoughts, links, videos, and images with your followers and be able to have conversations. _(This is basically a Twitter clone project)_.
***

#### Database ERD
![Database ERD](https://github.com/mcforma/Zinger/blob/main/Database/Project%20Step%204%20-%20Zinger%20ERD.png)
---

#### Draft WireFrames
---

##### Login page
![Login page](https://github.com/mcforma/Zinger/blob/main/Wireframe/Login.png)
---

##### Home
![Home](https://github.com/mcforma/Zinger/blob/main/Wireframe/Home.png)
---


##### Profile Page
![Profile Page](https://github.com/mcforma/Zinger/blob/main/Wireframe/Profile.png)
---

##### Messages
![Messages](https://github.com/mcforma/Zinger/blob/main/Wireframe/Messages.png)
---

##### Settings
![Settings](https://github.com/mcforma/Zinger/blob/main/Wireframe/Settings.png)

##### [User Stories](https://github.com/mcforma/Zinger/blob/main/Requirements/User%20Stories):

1. As a social person, I want a way to connect with my friends and family and meet new people so that we can interact 
socially when we can’t be together face-to-face (as with COVID-19).

2. As an employee of my company’s marketing division I need to ensure we have a wide social media presence so that we can 
garner a lot of views for advertisement.

3. As a person who moved to another state to take a job, I want a way to see my friends and family’s posts and activity in 
my feed so that I can stay up to date with them.

4. As an active member in my extended family,I want a secure way to privately message my family so that our data is protected 
and remains in our own control.

##### [Use Cases](https://github.com/mcforma/Zinger/blob/main/Requirements/Use%20Cases):

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


##### Zinger Use Case Diagram ![Zinger Use Case Diagram](https://github.com/mcforma/Zinger/blob/main/Requirements/Zinger%20Use%20Case%20Diagram.png)

##### [Requirements List](https://github.com/mcforma/Zinger/blob/main/Requirements/Requirements%20List):

1. The system will have display with option to click “log in” or “register”.<br>
  1.1. If user is a new user, they shall select “register”, else select “log in”.<br>
    1.1.1. If the user selects “log in”, then the system will prompt the user for their username and password and log the user in upon a valid check against the authentication service.<br>
    1.1.2. If the user selects “register”, they will be asked to provide basic information such as full name, date of birth, email address, display name, as well as creating a unique user handle, and a password that meets strong password requirements.<br>
      1.1.2.1. The system will check if the requested user handle is unique. If true, user may continue, if false, reject user handle as unavailable.<br>
      1.1.2.2. The system will require that user must agree to the terms of service before submitting account registration request.<br>
      1.1.2.3. The system will generate a unique user ID and send an email to the email address supplied by the user to verify their email address.<br>
      1.1.2.4. Upon verification the user will be able to log in as an existing user.<br>
    1.1.3. Upon a valid check of existing users supplied credentials against authentication server, user will log in.<br>
  1.2. The system shall have a home feed page.<br>
    1.2.1. The user shall be able to post “zings” which may contain text, images, emojis, video, or audio.<br>
    1.2.2. The home feed page shall be fed zings from users said user follows, as well as recommendations of people/accounts to follow.<br>
  1.3. The system shall allow user to search for other users and by hashtags in search bar.<br>
  1.4. The system shall allow user to reset password, deactivate or delete account, or download account data.<br>
  1.5. The system shall allow user to see how many views their zings receive.<br>
  1.6. The system shall have a private messaging system.<br>
    1.6.1. The private messaging system shall allow one user to message another directly.<br>
    1.6.2. The private messaging system shall have end-to-end encryption.<br>
2. The system shall save the data provided by users in the Zinger database.<br>
  2.1. The system shall provide a simple GUI similar to Twitter’s.<br>
  2.2. There will be a menu bar on the left side of the screen available on every page.<br>
  2.3. The user will input information via typing, text, or image, video, audio files.<br>
3. The system shall be developed using C#, T-SQL, and ASP.NET.<br>
  3.1. The system shall be hosted in GitHub and Azure.<br>

