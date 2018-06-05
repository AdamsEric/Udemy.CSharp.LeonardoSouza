class Produto {
    public id: number;
    public nome: string;

    public obterNome(): string {
        return this.nome;
    }

    public obterId(): number {
        return this.id;
    }

    set descricao(val) {

    }

    get descricao(): string {
        return this.nome;
    }
}

let produto = new Produto();