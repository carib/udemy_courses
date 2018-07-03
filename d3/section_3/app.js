d3.csv( 'data.csv' ).then(function( data ) {
    console.log( data );
    generate( data );
})

d3.json('data.json').then(function (data) {
    // console.log( data );
    // generate( data.columns );
})

const generate = ( dataset ) => {

    const el = d3.select( 'body' )
        .selectAll( 'p' )
        .data( dataset )
        .enter()
        .append( 'p' )
        .text(function( d ) {
            return 'This paragraph is binded to the number ' + d
        })
        .attr( 'class', (d) => {
            if (d > 25) {
                return 'foo'
            } else {
                return null
            }
        })
        .classed( 'bar', (d) => {
            return d < 25;
        })
        .style('color', (d) => {
            if (d < 25) {
                return 'red'
            } else {
                return 'blue'
            }
        });
    
    
    console.log(el)
}