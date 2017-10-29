#!/usr/bin/env python3

#Name: <James Wolf>
#Date: <10/20/2017>
#Project: <Midtermprogram>

print("Welcome to day of week calculator")
print("==================================")

#get year from user and check if valid.
while True:
    year = int(input("Please enter a year anything after 1582 \nEnter year (YYYY): "))
    if not year >= 1581:
        print("Cannot accept a year that is less than 1582. Please enter a valid year")
# Year Input is good exit loop and continue 
    else:
        break

# Get month from user and check if a valid month.
while True:
    month = int(input("Please enter a month as a number 1 through 12\nMonth (1-12): ")) 
    if ((month < 1) or (month > 12)):
        print("Invalid month entered. Please enter a month as a 1 through 12")
    else:
        break

#Math for determining the number of days in the month. Added uYear and uMonth so I could subtract 1 from year and add 12 to month if month is either Jan or Feb.

if month in [3, 5, 7, 8, 10, 12]:  
    days = range(1, 32)
    showDays = "(1-31)"
    uYear = year
    uMonth = month
elif month in [1]:
     days = (range(1, 32)) 
     showDays = "(1-31)"
     uYear = year
     uYear -= 1
     uMonth = month
     uMonth += 12
elif month in [4, 6, 9, 11]:
    days = range(1, 31)
    showDays = "(1-30)"
    uYear = year
    uMonth = month
elif (month == 2 and (year % 4 == 0 ) and (year % 400 == 0 or year % 100 != 0) ):
    days = range(1, 30)
    showDays = "(1-29)"
    uYear = year
    uYear -= 1
    uMonth = month
    uMonth += 12
elif month == 2:
    days = range(1, 29)
    showDays = "(1-28)"
    uYear = year
    uYear -= 1
    uMonth = month
    uMonth += 12
#print(list(days))


#Need to figure out how to include this month == 2 (month + 12) (year-1):*****Complete
#Need to figure out how to include this month == 1 (month + 12) (year-1)******Complete:

    

#Display number of days in the month and ask user to pick a day 
while True:
    uDays = int(input( "Day " + str(showDays) + ': ' ))
    if uDays not in list(days):
        print("Invalid input. Please pick a day that falls in the range shown.")
    else:
        break

#Determine the day of the week 
week = int(((uDays + 2 * uMonth) + (int( 0.6 * ( uMonth + 1 )))) + ((uYear + int( uYear / 4 ) - int( uYear / 100 )) + (int( uYear / 400 ) +2)))
#print(week)

#The remainder when week is divided by 7 is the day of the week of that given year. Saturday is 0, Sunday 1, Monday 2 and so on.
if ((week % 7) == 0):
    print(str(month) + "/" + str(uDays) + "/" + str(year) + " - Saturday")
elif ((week % 7) == 1):
    print(str(month) + "/" + str(uDays) + "/" + str(year) + " - Sunday")
elif ((week % 7) == 2):
    print(str(month) + "/" + str(uDays) + "/" + str(year) + " - Monday")
elif ((week % 7) == 3):
    print(str(month) + "/" + str(uDays) + "/" + str(year) + " - Tuesday")
elif ((week % 7) == 4):
    print(str(month) + "/" + str(uDays) + "/" + str(year) + " - Wednesday")
elif ((week % 7) == 5):
    print(str(month) + "/" + str(uDays) + "/" + str(year) + " - Thursday")
elif ((week % 7) == 6):
    print(str(month) + "/" + str(uDays) + "/" + str(year) + " - Friday")





    
