# Covid19 Recommender System - Windows Forms Application
An application to allow a person to enter details in categories such as personal details, vaccination details, symptom details, and safety questions. The entered details are displayed as shown in the sample output together with a recommendation to follow. 

The user should mention whether he/she is vaccinated or not. By default, ‘Not Vaccinated’ should be selected and the ‘Vaccine’ dropdown should be disabled with the text ‘No Vaccine’. If the user selects ‘Vaccinated’, then the ‘Vaccine’ dropdown should be enabled and the 0th index of vaccines should be selected from vaccines Pfizer, Moderna, AstraZeneca, Sinopharm, Sputnik V. Then the user can select a vaccine from the dropdown.

Under ‘All symptoms’ all the symptoms which can be seen among Covid19 patients are shown. Such symptoms are Fever, Cough, Tiredness, Loss of taste or smell, Sore throat, Headache, and Difficulty Breathing. The user can select the symptoms he/she is having by double-clicking on a symptom at a time. Then, the selected symptoms should be shown under ‘Symptoms you have’. To remove the selected symptoms under ‘Symptoms you have’, the user should double click on each symptom.

The user can tick to say ‘Yes’ and untick to say ‘No’ to the safety questions such as,
•	Do you wear masks in public?
•	Do you sanitize your hands?
•	Do you follow social distancing?

Initially, the empty output box should have a grey background. When clicking on the “Submit Details” button, all the details entered should be displayed in white text with necessary health recommendations as follows,

1.	You are Safe! No action is needed.
While showing this recommendation, the background color should be green with all the following conditions,
•	The user is vaccinated.
•	The user does not have any symptoms.
•	The user has answered ‘Yes’ to all the safety questions.

2.	You may not be Safe! Home quarantine is recommended.
While showing this recommendation, the background color should be orange with the following conditions,
•	The user has at least one symptom or a maximum of 3 symptoms.
OR
•	The user has answered ‘No’ for at least one safety question.
OR
•	The user is not vaccinated.

3.	You may be in Danger! Visit the nearest treatment center.
While showing this recommendation, the background color should be red with the following conditions,
•	The user has more than 3 symptoms.

### Sample Output
******* Personal Details *******

Name: John Smith

Age: 26 years old

NIC: 962137543V


******* Vaccination Details *******

Vaccine: Sinopharm


******* Symptoms *******

Cough

Fever



******* Safety Questions *******

Do you wear masks in public? : Yes

Do you sanitize your hands? : Yes

Do you follow social distancing? : No


******* Recommendation *******

You may not be Safe! Home quarantine is recommended.


### User Interfaces
![image](https://user-images.githubusercontent.com/49782156/169663008-d47aaaaf-0bf9-4de1-ac2e-019f4c58cb8f.png)
