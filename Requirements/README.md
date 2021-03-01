### [User Stories](https://github.com/mcforma/Zinger/blob/main/Requirements/User%20Stories):

1. As a social person, I want a way to connect with my friends and family and meet new people so that we can interact 
socially when we can’t be together face-to-face (as with COVID-19).

2. As an employee of my company’s marketing division I need to ensure we have a wide social media presence so that we can 
garner a lot of views for advertisement.

3. As a person who moved to another state to take a job, I want a way to see my friends and family’s posts and activity in 
my feed so that I can stay up to date with them.

4. As an active member in my extended family,I want a secure way to privately message my family so that our data is protected 
and remains in our own control.

### [Use Cases](https://github.com/mcforma/Zinger/blob/main/Requirements/Use%20Cases):

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


### Zinger Use Case Diagram ![Zinger Use Case Diagram](https://github.com/mcforma/Zinger/blob/main/Requirements/Zinger%20Use%20Case%20Diagram.png)

### [Requirements List](https://github.com/mcforma/Zinger/blob/main/Requirements/Requirements%20List):

1. The system will have display with option to click “log in” or “register”.
  1.1. If user is a new user, they shall select “register”, else select “log in”.
    1.1.1. If the user selects “log in”, then the system will prompt the user for their username and password and log the user in upon a valid check against the authentication service.
    1.1.2. If the user selects “register”, they will be asked to provide basic information such as full name, date of birth, email address, display name, as well as creating a unique user handle, and a password that meets strong password requirements. 
      1.1.2.1. The system will check if the requested user handle is unique. If true, user may continue, if false, reject user handle as unavailable.
      1.1.2.2. The system will require that user must agree to the terms of service before submitting account registration request
      1.1.2.3. The system will generate a unique user ID and send an email to the email address supplied by the user to verify their email address.
      1.1.2.4. Upon verification the user will be able to log in as an existing user.
    1.1.3. Upon a valid check of existing users supplied credentials against authentication server, user will log in.
  1.2. The system shall have a home feed page.
    1.2.1. The user shall be able to post “zings” which may contain text, images, emojis, video, or audio.
    1.2.2. The home feed page shall be fed zings from users said user follows, as well as recommendations of people/accounts to follow.
  1.3. The system shall allow user to search for other users and by hashtags in search bar. 
  1.4. The system shall allow user to reset password, deactivate or delete account, or download account data.
  1.5. The system shall allow user to see how many views their zings receive.
  1.6. The system shall have a private messaging system.
    1.6.1. The private messaging system shall allow one user to message another directly
    1.6.2. The private messaging system shall have end-to-end encryption.
2. The system shall save the data provided by users in the Zinger database.
  2.1. The system shall provide a simple GUI similar to Twitter’s.
  2.2. There will be a menu bar on the left side of the screen available on every page.
  2.3. The user will input information via typing, text, or image, video, audio files.
3. The system shall be developed using C#, T-SQL, and ASP.NET.
  3.1. The system shall be hosted in GitHub and Azure.
