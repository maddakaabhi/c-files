# !/bin/bash -x
ispresent=1
check=$((RANDOM%2))
if [ $ispresent -eq $check ];then
echo "employee is present"
else
echo "employee is absent"
fi
