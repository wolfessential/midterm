#!/usr/bin/env python3

#Name: <James Wolf>
#Date: <10/20/2017>
#Project: <Midtermprogram>

print("Welcome to day of week calculator")
print("==================================")

#get year from user and check if valid also subtract 1 from given year to help with calculation later.
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

#Math for determining the number of days in the month. If user input is Jan uary or February also subtract 1 from year to help calculate date later.

if month in [3, 5, 7, 8, 10, 12]:  
    days = range(1, 32)
    showDays = "(1-31)"
elif month in [1]:
     days = (range(1, 32)) 
     showDays = "(1-31)"
elif month in [4, 6, 9, 11]:
    days = range(1, 31)
    showDays = "(1-30)"
elif (month == 2 and (year % 4 == 0 ) and (year % 400 == 0 or year % 100 != 0) ):
    days = range(1, 30)
    showDays = "(1-29)"
elif month == 2:
    days = range(1, 29)
    showDays = "(1-28)"
#print(list(days))


#Need to figure out how to include this month == 2 (month + 12) (year-1):
#Need to figure out how to include this month == 1 (month + 12) (year-1):

    

#Display number of days in the month and ask user to pick a day 
while True:
    uDays = int(input( "Day " + str(showDays) + ': ' ))
    if uDays not in list(days):
        print("Invalid input. Please pick a day that falls in the range shown.")
    else:
        break

#Determine the day of the week 
week = int(((uDays + 2 * month) + (int( 0.6 * ( month + 1 )))) + ((year + int( year / 4 ) - int( year / 100 )) + (int( year / 400 ) +2)))
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





    