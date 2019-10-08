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
                console.log("Asiakas-data ladattu." );

                reactKomponentti.setState({ asiakkaat: json });
            });

        console.log("Fetch-kutsu tehty");
    }

    render() {
        console.log("OwnComponent.render()");

        let lkm = this.state.asiakkaat.length;
        var taulukko = [];
        for (let index = 0; index < lkm; index++) {
            let asiakas = this.state.asiakkaat[index];

            taulukko.push(<tr>
                <td>{asiakas.customerId}</td>
                <td>{asiakas.companyName}</td>
                <td>{asiakas.contactName}</td>
                <td>{asiakas.country}</td>
                <td>{asiakas.phone}</td>
            </tr>);
        }

        return <div>
            <table class="table table-striped">
                <thead>
                    <tr>
                        <th>Asiakas-Id</th>
                        <th>Yrityksen nimi</th>
                        <th>Kontaktihenkilö</th>
                        <th>Maa</th>
                        <th>Puhelin</th>
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