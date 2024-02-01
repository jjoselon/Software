# Jmeter How to

- [How to pass variables across thread groups in jmeter](https://stackoverflow.com/questions/35084011/how-to-pass-variables-across-thread-groups-in-jmeter?rq=3)
- [Jmeter functions](https://jmeter.apache.org/usermanual/functions.html#__property)
- [Jmeter variables (outdated)](https://www.blazemeter.com/blog/jmeter-variables)

Example: `Token - Thread Group` sets a variable in **JSON Extractor - PostProcessor** according to sampler response and will be used in the next thread Group node with the `${__property('var_name')}`
