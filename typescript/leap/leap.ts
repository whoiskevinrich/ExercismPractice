function isLeapYear( year:number ) {
    let isLeapYear = year % 4 == 0;
    let isSkippedLeapYear = year % 100 == 0;
    let isReintroducedLeapYear = year % 400 == 0;
    
    return (isLeapYear && (!isSkippedLeapYear || isReintroducedLeapYear));
}

export default isLeapYear