for category in ./*/
do
	for deck in $category*/
	do
		./publish.sh $deck
	done
done

