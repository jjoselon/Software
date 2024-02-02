# Jmeter How to

## Global variables across thread groups in Jmeter
- [How to pass variables across thread groups in jmeter](https://stackoverflow.com/questions/35084011/how-to-pass-variables-across-thread-groups-in-jmeter?rq=3)
- [Jmeter functions](https://jmeter.apache.org/usermanual/functions.html#__property)
- [Jmeter variables (outdated)](https://www.blazemeter.com/blog/jmeter-variables)

Example: `Token - Thread Group` sets a variable in **JSON Extractor - PostProcessor** according to sampler response and will be used in the next thread Group node with the `${__property('var_name')}`

## JSON Extractor 
- [How to extract and pass the value in json extractor in Jmeter](https://stackoverflow.com/questions/63537234/how-to-extract-and-pass-the-value-in-json-extractor-in-jmeter)
- [JSON Extractor Post Processor](https://www.blazemeter.com/blog/json-extractor)
- [How to save response in a variable in jmeter](https://stackoverflow.com/questions/34463412/how-to-save-response-in-a-variable-in-jmeter)

## Variables Management
- [Handling variables in Jmeter](https://dev.to/adamleszko/guide-to-handling-variables-in-jmeter-3hkb)

## Jmeter listeners list
- [Jmeter listeners](https://www.blazemeter.com/blog/jmeter-listeners)
