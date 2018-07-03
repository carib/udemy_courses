# Lecture Notes
## Section 4, Lecture 39
Congrats on making it this far! You can view all the lecture notes here just in case you need them. Please be sure to let me know if you have any questions. Thanks!

## Lectures Notes
### First Steps

* D3 can be used to create any type of visualization. It’s not biased towards nay chart or graph.
* Adobe color is a tool that allows you to find great color combinations and even build your own. 
* You can use the data to change the outcome of the bar/chart. Most commonly used to manipulate the height or height.

### Random Data

* Generating Random data can help battle test your graph as it allows you to cover more scenarios.
* There are situations where clients may not be able to provide you data so you’ll be responsible for generating dummy data in the mean time. 
* The D3 random library takes care of generating random data for you.
### Using SVG

* Moving SVG elements requires that you change their x and y coordinates. The X coordinate goes from left to right and the y coordinate goes from top to bottom. 
* If you’re reusing values, then you should store it in a variable. This makes it easy to change later on if you ever need to.
* Labels are a way to identify a shape. Users will be able to better understand compare your visualization if you provide labels.
* Text anchoring is special to SVG. You can determine whether text gets pushed form its side or center point.
### Scatter Plot

* Scatter plots allow you to chart large amounts of data. They are circles that represent 2 pieces of data. They can also vary in size to show more impact over others.
* Creating a scatter plot is similar to creating a bar graph. You create the elements, bind the data, create more elements for the data and add details.
* You can use the join() function to combine arrays to strings. This can be useful for displaying coordinates stored in arrays. 
* Math is used to position and set the size of elements. D3 can take care of the more complex operations so you don’t have to.
### Scales

* Scales are functions that take your data and will lower or increase the values so that they can be used for visualization.
* The input domain is the original set of data. It’s the highest and lowest numbers in your data.
* The output range is the numbers that the original data should be scaled to. These would usually be size of the viewing area.
* The D3 array library is a utility library that provides functions for working with arrays no matter how complex. It’s included in the core by default so you don’t need to do anything to set it up.
### Applying Scales to Visualizations

* The d3.max() and d3.min() functions can be passed in accessor functions for complex array and object structures.
* An accessor function is a function that returns a value that’s used for grabbing certain data from an object or array.
* Adding padding to your visualizations is common so that shapes and text don’t get cut off from the viewing area.
* You can reverse the range and D3 will take care of scaling the values appropriately for you.
### Exploring More Scales

* D3 provides various scales for various scenarios. An official list of scales can be found on the D3 Scales library.
* Each scale can be used for scaling different types of shapes such as the scaleSqrt() function for circles.
* Some scales are used for data that don’t contain numeric values such as colors or categorical data.
### Time Scales

* Dates in your data will most likely come in a format that neither D3 or JavaScript can understand. D3 only works with Date Objects.
* There are a set of functions that will take care of reading your formatted dates and converting them into date objects to use with scales and vice versa.
* MomentJS is also a popular library for converting dates. You can use this if you’re comfortable with it.
* D3’s time scale will read your dates and convert them into numbers that can be used to visualize your data.
### Adding an Axis

* An axis is a line with ticks that provide a way to visually measure the distance between certain points in a graph. D3 provides a set of functions for creating an axis.
* The axisTop() and axisBottom() functions are used for creating a horizontal axis. The axisLeft() and axisRight() functions are used for creating a vertical axis.
* Unlike scales, these functions will draw the SVG elements for you. It’s good practice to store these generated elements inside a group so they can be moved and managed easily.
* You can use CSS to refine the outcome of your SVG shapes. The more cleaner a shape looks, the more resources is required to render it. 
### Refining the Axis and adding the Y Axis

* The ticks() function allows you to set a number of ticks an axis should have. The number will only be taken as a suggestion.
* The tickValues() function will allow you to completely control how many ticks are outputted along with the actual values themselves. D3 will take the time to space them out.
* The tickFormat() function will allow you to format the text that gets outputted for each tick. You are provided the data for each tick so you can manipulate it appropriately. 