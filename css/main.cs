/* Error: Can't find stylesheet to import.
 *    ,
 * 27 | @use 'layout/navigatio';
 *    | ^^^^^^^^^^^^^^^^^^^^^^^
 *    '
 *   sass\main.scss 27:1  root stylesheet */

body::before {
  font-family: "Source Code Pro", "SF Mono", Monaco, Inconsolata, "Fira Mono",
      "Droid Sans Mono", monospace, monospace;
  white-space: pre;
  display: block;
  padding: 1em;
  margin-bottom: 1em;
  border-bottom: 2px solid black;
  content: "Error: Can't find stylesheet to import.\a    \2577 \a 27 \2502  @use 'layout/navigatio';\d\a    \2502  ^^^^^^^^^^^^^^^^^^^^^^^\a    \2575 \a   sass\\main.scss 27:1  root stylesheet";
}
