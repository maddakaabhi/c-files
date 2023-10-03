# !/bin/bash -x
read -p "enter year" year
if [[ $year%4 -eq  0 && $year -ne 0 || $year%400 -eq 0 ]];then
echo "$year is Leap year "
else
echo "$year is not Leap year"
fi  
