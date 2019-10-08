import React from 'react';

class OwnComponent extends React.Component {

    constructor(props) {
        console.log("OwnComponent.constructor()");
        
        super(props);
        this.state = { asiakkaat:[] };
    }

    componentDidMount() {
        console.log("OwnComponent.componentDidMount()");

        let reactKomponentti = this;
        fetch('https://localhost:5001/api/customers')
            .then(response => response.json())
            .then(json => {
                console.log("Asiakas-data ladattu.");

                reactKomponentti.setState({ asiakkaat: json });
            });

        console.log("Fetch-kutsu tehty");
    }

    render() {
        console.log("OwnComponent.render()");

        var taulukko = [];
        for (let index = 1; index <= 10; index++) {
            taulukko.push(<tr>
                <td>{index}-1</td>
                <td>{index}-2</td>
                <td>{index}-3</td>
            </tr>);
        }

        return <div>
            <table class="table table-striped">
                <thead>
                    <tr>
                        <th>Sarake 1</th>
                        <th>Sarake 2</th>
                        <th>Sarake 3</th>
                    </tr>
                </thead>
                <tbody>
                    {taulukko}
                </tbody>
            </table>
        </div>;
    }
}

export default OwnComponent;