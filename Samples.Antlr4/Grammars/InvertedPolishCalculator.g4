grammar InvertedPolishCalculator;

/*
 * Parser Rules
 */
 input
	: operation;

operation
	: operande expression OPERATOR
	;

expression
	: operation
	| operande
	;

operande
	: negative 
	| number
	;

number : NUMBER;
negative : NEGATIVE_NUMBER;
/*
 * Lexer Rules
 */
fragment DIGIT : [0-9] ;
NUMBER: DIGIT+ ([.] DIGIT+)? ;
NEGATIVE_NUMBER: MINUS DIGIT;
FIRST_NUMBER: NUMBER;
SECOND_NUMBER: NUMBER;
OPERATOR: PLUS | MINUS | MUL | DIV;	
PLUS: '+';
MINUS: '-';
MUL: '*';
DIV: '/';