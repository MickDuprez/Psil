# Psil - a reverse Lisp Scripting Language

Psil is my attempt to create a more user friendly Lisp interpreter for use in .Net.

It will sit on top of my study of Make a Lisp (MAL) but the general idea is to make a language 
as close to Lisp as possible but reorganising the s-expr's into a 'pipe' style like F#, Elixir et al.
The underlying interpeter will be basically Lisp and a custom parser will do the work of reordering the expressions
to build the AST which will work as normal.