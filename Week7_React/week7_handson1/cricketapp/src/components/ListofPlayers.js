import React from 'react';
function ListofPlayers() {
  const players = [
    { name: 'Rohit Sharma (IND)', score: 85 },
    { name: 'Joe Root (ENG)', score: 70 },
    { name: 'Steve Smith (AUS)', score: 65 },
    { name: 'Kane Williamson (NZ)', score: 90 },
    { name: 'Babar Azam (PAK)', score: 45 },
    { name: 'Shreyas Iyer (IND)', score: 75 },
    { name: 'David Warner (AUS)', score: 62 },
    { name: 'KL Rahul (IND)', score: 55 },
    { name: 'Mitchell Starc (AUS)', score: 95 },
    { name: 'Rashid Khan (AFG)', score: 72 },
    { name: 'Mohammed Siraj (IND)', score: 40 }
  ];

  const lowScorers = players.filter(p => p.score < 70);

  return (
    <div>
      <h2>All Players (Mixed Indian + Foreign)</h2>
      {players.map((player, index) => (
        <p key={index}>{player.name}: {player.score}</p>
      ))}

      <h3>Players with score below 70</h3>
      {lowScorers.map((player, index) => (
        <p key={index}>{player.name}: {player.score}</p>
      ))}
    </div>
  );
}

export default ListofPlayers;
