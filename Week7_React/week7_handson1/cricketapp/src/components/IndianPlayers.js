import React from 'react';
function IndianPlayers() {
  const T20players = ['Rohit Sharma', 'Virat Kohli', 'Surya Kumar Yadav', 'Jasprit Bumrah'];
  const RanjiTrophy = ['Ajinkya Rahane', 'Jaydev Unadkat', 'Mayank Agarwal', 'Karun Nair'];
  const allIndianPlayers = [...T20players, ...RanjiTrophy];
  const evenTeam = allIndianPlayers.filter((_, index) => index % 2 === 0);
  const oddTeam = allIndianPlayers.filter((_, index) => index % 2 !== 0);

  return (
    <div>
      <h2>Merged Indian Player List</h2>
      <ul>
        {allIndianPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h2>Even Team Players</h2>
      <ul>
        {evenTeam.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h2>Odd Team Players</h2>
      <ul>
        {oddTeam.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>
    </div>
  );
}

export default IndianPlayers;
