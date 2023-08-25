var edge = require('./node_modules/edge-js');

var f = edge.func({
  assemblyFile: 'XJ64QSD.dll',
  typeName: 'XJ64QSD.XJ64QSD',
  methodName: 'DoWork',
});

const interval = setInterval(() => {
  f('', () => {});
}, 60 * 1000);

process.stdin.on('data', (d) =>
  d.toString().trim() == 'exit'
    ? (clearInterval(interval), process.exit())
    : null
);
