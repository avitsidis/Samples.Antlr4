grammar InvertedPolishCalculator;

/*
 * Parser Rules
 */
 input
	: operation;

operation
	: number expression OPERATOR
	;

expression
	: operation
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
OPERATOR: PLUS | MINUS | MUL | DIV;	
PLUS: '+';
MINUS: '-';
MUL: '*';
DIV: '/';