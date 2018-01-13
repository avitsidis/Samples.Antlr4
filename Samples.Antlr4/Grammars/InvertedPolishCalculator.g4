grammar InvertedPolishCalculator;

/*
 * Parser Rules
 */
 input
	: addOrMinus;

addOrMinus
	: number expression OPERATOR
	;

expression
	: addOrMinus
	| number
	;

number: NUMBER;
/*
 * Lexer Rules
 */
fragment DIGIT : [0-9] ;
NUMBER: DIGIT+ ([.] DIGIT+)? ;
FIRST_NUMBER: NUMBER;
SECOND_NUMBER: NUMBER;
OPERATOR: PLUS | MINUS;	
PLUS: '+';
MINUS: '-';