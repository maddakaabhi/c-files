# !/bin/bash -x
declare -A y
for (( i=0 ;i<=4 ;i++ ));do
y[$i]=$(($i+2))
done
echo ${y[@]}

echo ${y[0]}

unset y[0]
echo ${y[@]}

y+=([5]=10)
echo ${y[@]}

if [ ${y[10]}+_ ];then
echo "found"                       #checking the key is present or not
else
echo "not found"
fi
