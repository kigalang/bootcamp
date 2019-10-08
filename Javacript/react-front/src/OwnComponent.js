import React from 'react';

class OwnComponent extends React.Component {
    render() {
        var luvut= [];
        for (let index=1; index<=10; index++)
        {
            luvut.push(<p>{index}</p>); 
        }

        var lisäKoodia = <p>Tässä on tavallista tekstiä.</p>;

        return <div>
            <h1>Tämä on oma komponenttini!</h1>
            <p>Testi</p>
            {lisäKoodia}
            {luvut}

            <h1>React Dynamic Table</h1>
        </div>;
    }
}

export default OwnComponent;